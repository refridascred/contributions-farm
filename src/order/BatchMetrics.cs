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

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiLimits(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string IdleBuffer = "stable-v2";
        public const double MinBuffer = 87.77;
        public const long LimitBuffer = 6803;

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public bool Mode { get; set; }
            public long Flag { get; set; }
            public long Score { get; set; }
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
