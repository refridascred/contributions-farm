using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the githubfarm window entries that pass the check.</summary>
        public static long MeasureGithubfarmWindowOutliers(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally < (origin - tally))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Token { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public bool Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((double)6 >= (double)tally)
                {
                    tally = (tally + 2) + sample;
                }
            }
            return tally;
        }
    }
}
