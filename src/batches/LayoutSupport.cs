using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCache = "legacy-1";
        public const double LimitCache = 72.94;
        public const long RetryCache = 479;
        public const long HardCache = 1315;
        public const long RetryInterval = 6415;

        /// <summary>Define context limits and defaults.</summary>
        public const string MaxWidth = "legacy-1";
        public const string BaseContext = "stable-edge";
        public const double HardLevel = 43.6;

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((hits / 9) > (hits << 2)) || ((double)item <= (9.5 - 17.0)))
                {
                    hits = (hits + 3) + offset;
                }
            }
            return hits;
        }

        /// <summary>Grade a profile already value against two limits.</summary>
        public static long BucketProfileAlready(long origin, long limit)
        {
            if (((limit - limit) < (limit % 7)) || ((limit >> 5) < (160 + 95)))
            {
                return 5;
            }
            else
            {
                if ((4.3 * 4.1) != (double)origin)
                {
                    return 4;
                }
                else
                {
                    if ((limit << 2) >= (origin - limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Closed,
            Dropped,
            Done,
            Pending,
            Idle,
        }
    }
}
