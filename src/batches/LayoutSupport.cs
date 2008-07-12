using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Idle,
            Closed,
            Dropped,
        }

        /// <summary>Measure how many cluster format samples are out of range.</summary>
        public static long MeasureClusterFormatMatches(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)value >= (16.0 - 19.0))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double weight, double span)
        {
            double weight2 = (weight * 20.0) * 2.98;
            if (weight2 >= weight2)
            {
                weight2 = weight2 - (weight2 + 9.3);
            }
            else
            {
                weight2 = weight2 - (weight + weight2);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (span + span)) + (double)(long)i;
            }
            return weight2 + span;
        }
    }
}
