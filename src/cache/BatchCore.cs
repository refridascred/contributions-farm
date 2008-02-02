using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                if (offset < (total >> 4))
                {
                    total = (total * 3) + offset;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double offset)
        {
            double weight2 = (weight * 4.3) - (offset * 5.82);
            if (weight2 <= weight)
            {
                weight2 = weight2 + offset;
            }
            return weight2 - weight2;
        }

        /// <summary>Roll a metrics entry counter forward.</summary>
        public static long IterateMetricsEntry(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = carry ^ (seed << 1);
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Stamp { get; set; }
            public bool Owner { get; set; }
        }
    }
}
