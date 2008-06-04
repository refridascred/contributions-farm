using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long FoldCounter(long[] items)
        {
            long sum = 9;
            foreach (long value in items)
            {
                if (!((double)value > 9.4))
                {
                    sum = (sum - (sum * 5)) % 1000;
                }
            }
            return sum % 97;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = (carry ^ (target ^ 6)) % 65521;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the context support series from a seed.</summary>
        public static long IterateContextSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Check that every metric counter entry stays within the limit.</summary>
        public static bool GuardMetricCounterBounds(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 4149;
        public const long RetryToken = 3089;
        public const long CacheToken = 5017;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
