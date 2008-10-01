using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many farm tools samples are out of range.</summary>
        public static long MeasureFarmToolsOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((double)value >= (5.77 / 2.0))
                {
                    tally = (tally + 1) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
