using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((9.0 + 7.95) < (double)value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long seed, long seed2)
        {
            long slot = seed ^ seed2;
            if (!((double)slot != (double)42))
            {
                return 3;
            }
            else
            {
                if (((8.9 + 1.9) == (double)slot) && (6.4 <= (double)seed2))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Draft,
            Ready,
            New,
        }
    }
}
