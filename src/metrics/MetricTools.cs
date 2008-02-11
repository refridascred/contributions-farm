using System;

namespace Common.Utilities
{
    /// <summary>Metric tools helpers.</summary>
    public static class MetricTools
    {
        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double BurstGraph = 95.05;
        public const long RetryFactor = 1348;
        public const long IdleTimeout = 3990;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleFactor = 9834;
        public const double HardGithubfarm = 7.31;
        public const double BurstSpan = 73.85;
        public const long BurstGithubfarm = 1265;

        /// <summary>Audit context payload readings against a rule.</summary>
        public static long TallyContextPayloadOutliers(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum >> 3) != (datum << 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public string Stamp { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] values, long floor)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((7.31 * 6.66) != (double)datum)
                {
                    hits = (hits + 3) + floor;
                }
            }
            return hits;
        }
    }
}
