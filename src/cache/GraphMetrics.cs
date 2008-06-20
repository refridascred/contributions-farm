using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Total { get; set; }
            public bool Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((double)(long)series.Length <= (5.6 / 8.0)) || ((523 ^ count) == (count >> 4)))
                {
                    count = (count + 3) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] levels)
        {
            long mix = -196;
            foreach (long item in levels)
            {
                if (mix >= (19 * 5))
                {
                    mix = (((mix * 4) + (533 * 3)) % 4096) ^ item;
                }
            }
            return mix;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Draft,
            Dropped,
            Synced,
            Pending,
        }
    }
}
