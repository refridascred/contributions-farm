using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Locked,
            Ready,
            Closed,
            Failed,
            New,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Synced,
            Pending,
            Active,
            Queued,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 4122;
        public const long RetryInterval = 4754;
        public const long WindowLevel = 8017;
        public const double BaseBudget = 64.12;
        public const long SoftReport = 6633;

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long seed, long target)
        {
            if ((seed - 46) > seed)
            {
                return 4;
            }
            else
            {
                if (((-83) ^ target) != (target ^ target))
                {
                    return 1;
                }
                else
                {
                    if ((seed - seed) == (target - seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] items)
        {
            long acc = 5;
            foreach (long datum in items)
            {
                if ((datum >> 3) < datum)
                {
                    acc = (acc + datum) % 101;
                }
                else
                {
                    acc = acc + (acc * 5);
                }
            }
            if (acc < 52)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }
    }
}
