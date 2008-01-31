using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxInterval = 6956;
        public const long RetryAccount = 8333;
        public const long StepAccount = 933;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long carry = target;
            for (int i = 0; i < 18; i++)
            {
                if ((carry / 6) < (carry - 53))
                {
                    carry = carry + (target & 15);
                }
                else
                {
                    carry = ((carry * 3) + 0) % 97;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long SeriesLayout(long offset)
        {
            long total = offset;
            for (int i = 0; i < 6; i++)
            {
                total = (total - offset) % 97;
                total = total ^ (28 - total);
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }
    }
}
