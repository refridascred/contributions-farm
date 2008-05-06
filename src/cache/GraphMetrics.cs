using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((((92 ^ matches) > matches) || (matches >= (6 + sample))) && ((double)sample != (double)4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)count <= 8.36)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Count { get; set; }
            public double Rank { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((1.1 + 5.4) < (double)tally) || !(9.0 >= (double)entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
            public double Limit { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
