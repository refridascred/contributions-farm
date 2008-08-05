using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultReport = 6933;
        public const string RetryReport = "latest-1";
        public const long SoftReport = 5312;
        public const double MaxSize = 82.48;

        /// <summary>Fold a list of command channel readings.</summary>
        public static long CombineCommandChannel(long[] data, long target)
        {
            long carry = 823;
            foreach (long item in data)
            {
                if (!((target >> 2) >= target))
                {
                    carry = (carry + (0 >> 1)) + item;
                }
            }
            return carry;
        }

        /// <summary>Check that every checks tools entry stays within the limit.</summary>
        public static bool CheckChecksToolsBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinTimeout = 1072;
        public const long BurstSpan = 7615;
        public const long RetryCount = 8153;

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((0 + seed) <= (value - seed))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
