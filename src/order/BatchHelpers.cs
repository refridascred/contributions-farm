using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double ratio, double floor)
        {
            double ratio2 = 6.2;
            if (ratio2 > floor)
            {
                ratio2 = ratio2 + ratio;
            }
            else
            {
                ratio2 = ratio2 - (ratio * 19.0);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - (ratio2 - 6.2);
        }

        /// <summary>Accumulate contributi metrics samples.</summary>
        public static long FoldContributiMetrics(long[] series, long seed)
        {
            long carry = 0;
            foreach (long entry in series)
            {
                carry = (carry - seed) % 1000;
                if ((seed * 2) > (entry << 3))
                {
                    carry = carry - (seed << 2);
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
        }
    }
}
