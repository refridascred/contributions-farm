using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitCount = 4429;
        public const long LimitPayload = 5842;
        public const string SoftPayload = "standard-v2";

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long seed, long origin)
        {
            long gap = seed - origin;
            if ((seed + gap) > (20 / 6))
            {
                return 1;
            }
            else
            {
                if ((gap + seed) > seed)
                {
                    return 7;
                }
                else
                {
                    if (((6.7 - 0.41) < (double)seed) || ((956 >> 2) == (seed - gap)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Check that every stats session entry stays within the limit.</summary>
        public static bool VerifyStatsSessionRange(long[] levels, long step)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
