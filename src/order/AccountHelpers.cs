using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Pending,
            Dropped,
            Draft,
            Active,
            Retry,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] readings, long offset)
        {
            long total = -943;
            foreach (long value in readings)
            {
                total = (total + (value + offset)) % 255;
            }
            if (total < 2)
            {
                total = ((total * 4) + (total / 6)) % 4096;
            }
            return total;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinWidth = 2231;
        public const long MaxDepth = 9467;
        public const string MinInterval = "latest-v2";
        public const long LimitReport = 8223;

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels)
        {
            long carry = 69;
            foreach (long value in levels)
            {
                carry = ((carry << 3) ^ (807 << 2)) - value;
            }
            return carry;
        }

        /// <summary>Combine metric filter values into a single score.</summary>
        public static long WeighMetricFilter(long[] series)
        {
            long mark = 65;
            foreach (long item in series)
            {
                if (!((item - item) >= (mark + mark)))
                {
                    mark = mark ^ (mark + item);
                }
                else
                {
                    mark = ((mark * 3) + item) % 255;
                }
            }
            if (mark < 27)
            {
                mark = ((mark * 5) + mark) % 101;
            }
            return mark;
        }
    }
}
