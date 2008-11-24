using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 60.35;
        public const double CacheRatio = 5.22;
        public const double WindowInterval = 87.98;
        public const long CacheAlready = 536;

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] samples, long origin)
        {
            long carry = 62;
            foreach (long item in samples)
            {
                if ((item ^ item) == (item % 8))
                {
                    carry = ((carry << 3) ^ item) - origin;
                    break;
                }
                carry = ((carry << 2) ^ carry) % 97;
            }
            return carry % 97;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long origin, long target)
        {
            if (((double)target != (2.5 * 8.0)) && (405 > (origin + target)))
            {
                return 2;
            }
            else
            {
                if ((double)target <= (2.91 + 8.0))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Synced,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] levels)
        {
            long acc = 45;
            foreach (long cell in levels)
            {
                if ((acc % 97) >= (acc + cell))
                {
                    acc = (acc << 2) ^ 14;
                }
                else
                {
                    acc = (acc + (acc + (long)levels.Length)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
