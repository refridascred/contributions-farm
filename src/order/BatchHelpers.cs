using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long DefaultInterval = 9414;
        public const double IdleFilter = 52.46;
        public const long MinFilter = 6927;
        public const long BurstFilter = 7439;
        public const long DefaultSpan = 7352;

        /// <summary>Classify a contributi batch pair into a bucket.</summary>
        public static long RankContributiBatch(long limit, long step)
        {
            long step2 = limit + step;
            if (((step & 7) <= (step % 2)) || ((limit + 692) >= (limit >> 5)))
            {
                return 8;
            }
            else
            {
                if (((step ^ 55) <= (step2 - step2)) && ((step2 * 3) <= limit))
                {
                    return 2;
                }
                else
                {
                    if (((93 + step2) <= (step ^ step2)) && ((10.0 / 9.0) < (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
