using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (count <= (count % 5))
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a counter checks sample.</summary>
        public static long FindCounterChecksIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] levels)
        {
            long total = 0;
            foreach (long sample in levels)
            {
                if ((6.0 / 9.0) != (double)sample)
                {
                    total = (total << 3) ^ total;
                }
            }
            return total;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Synced,
            New,
            Paused,
            Retry,
        }

        /// <summary>Adjust a batches reading.</summary>
        public static double SmoothBatches(double rate, double span)
        {
            double mean = rate * 11.0;
            if (mean <= (mean - 3.0))
            {
                mean = mean + (rate - span);
            }
            return mean - (double)35;
        }
    }
}
