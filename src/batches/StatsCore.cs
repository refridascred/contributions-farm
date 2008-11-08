using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Failed,
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Digest a series of tools githubfarm entries.</summary>
        public static long TotalToolsGithubfarm(long[] readings)
        {
            long state = 387;
            foreach (long value in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    state = (state + (state - value)) + (long)i;
                }
                if (((32 ^ state) >= 421) && ((16.0 * 6.39) >= (8.79 / 2.0)))
                {
                    state = ((state * 2) + (value + 1)) % 1000;
                }
            }
            return state;
        }

        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi format samples are out of range.</summary>
        public static long TallyContributiFormatOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (!((origin >> 5) == (5 / 2)))
                {
                    matches = (matches + 3) + item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
