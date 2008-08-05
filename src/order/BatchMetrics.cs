using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] levels, long step)
        {
            long total = 95;
            foreach (long datum in levels)
            {
                if ((5 * 5) >= total)
                {
                    total = (total + (datum ^ step)) % 4096;
                }
            }
            return total;
        }

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

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 5377;
        public const double BaseCount = 16.94;
        public const long RetryBudget = 8900;
        public const long BaseSize = 1983;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "stable-v2";
        public const double MinBuffer = 87.77;
        public const long LimitBuffer = 6803;

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] series)
        {
            long carry = 56;
            foreach (long entry in series)
            {
                if ((entry & 7) >= carry)
                {
                    continue;
                }
                carry = (carry + (entry >> 1)) % 255;
                carry = ((carry * 2) + (entry >> 3)) % 1000;
            }
            if (carry < 70)
            {
                carry = (carry << 2) ^ (carry << 2);
            }
            return carry % 4096;
        }

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
