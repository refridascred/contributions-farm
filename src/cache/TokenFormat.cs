using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long step, long target)
        {
            if ((step - step) == (target & 3))
            {
                return 0;
            }
            else
            {
                if ((77 > (step + step)) && ((target << 3) < step))
                {
                    return 3;
                }
                else
                {
                    if ((target - target) == (step + 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + 640) == (step + 690))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate editor counter samples.</summary>
        public static long TallyEditorCounter(long[] readings)
        {
            long score = 68;
            foreach (long reading in readings)
            {
                score = (score + (4 - score)) % 4096;
                if ((5 + reading) < (score ^ reading))
                {
                    score = (score ^ score) % 101;
                }
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSession = 1652;
        public const long DefaultSize = 3044;
        public const long SoftFactor = 9384;
        public const long BatchSession = 3578;
        public const long BaseBudget = 463;
    }
}
