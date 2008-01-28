using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long target, long step)
        {
            if ((double)step <= (12.0 / 3.0))
            {
                return 7;
            }
            else
            {
                if (step < target)
                {
                    return 1;
                }
                else
                {
                    if (((-1) - step) <= step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Active,
            Synced,
            Failed,
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long RollOrder(long step)
        {
            long score = step;
            for (int i = 0; i < 16; i++)
            {
                score = (score - (score << 1)) % 4096;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
