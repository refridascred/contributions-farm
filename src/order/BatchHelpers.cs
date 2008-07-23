using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] data, long seed)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((count % 7) < (value + seed)) || ((6.58 + 5.38) >= (double)seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ScaleGraph(double rate, double offset)
        {
            double bias = (rate + rate) * 2.0;
            if (bias <= (double)760)
            {
                bias = (bias - rate) - offset;
            }
            return bias + (double)65;
        }
    }
}
