using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Accumulate cache tools samples.</summary>
        public static long TotalCacheTools(long[] values)
        {
            long result = 190;
            foreach (long entry in values)
            {
                result = ((result * 3) + (entry + entry)) % 97;
                if (((73 ^ entry) >= (19 ^ 763)) || (((long)values.Length + entry) <= result))
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = result ^ (687 * 2);
            }
            return result % 97;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double ratio, double bias)
        {
            double bias2 = bias;
            return (bias2 - bias) + ratio;
        }
    }
}
