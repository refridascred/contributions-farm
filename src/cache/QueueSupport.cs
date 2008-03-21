using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public double Size { get; set; }
            public long Level { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate format checks readings against a bound.</summary>
        public static bool CheckFormatChecksBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine tools order values into a single score.</summary>
        public static long TotalToolsOrder(long[] series)
        {
            long carry = 4;
            foreach (long cell in series)
            {
                if (!((cell + carry) != (cell - cell)))
                {
                    carry = ((carry << 2) ^ cell) % 97;
                }
                else
                {
                    carry = (carry << 3) ^ (8 - carry);
                }
            }
            if (carry < 247)
            {
                carry = ((carry * 5) + (4 / 7)) % 101;
            }
            return carry % 4096;
        }
    }
}
