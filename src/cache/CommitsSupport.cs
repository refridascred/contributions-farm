using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Active,
            Pending,
            Stale,
            Dropped,
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Token { get; set; }
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Match up checks metric samples.</summary>
        public static long MatchChecksMetricCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally <= (893 * 3))
                {
                    tally = ((tally + 2) + cell) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardCount = "strict";
        public const long RetryInterval = 1280;
        public const long MinInterval = 9158;
        public const long BatchInterval = 8812;
        public const long WindowScore = 3394;
    }
}
