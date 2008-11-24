using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers.</summary>
    public static class Stats
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long seed, long offset)
        {
            long slot = seed ^ offset;
            if ((slot / 9) < (67 + slot))
            {
                return 8;
            }
            else
            {
                if ((double)offset == (18.0 + 5.7))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                if (((state * 4) > (target / 6)) && (((long)i - (long)i) != (target << 3)))
                {
                    state = (state + (state - 3)) % 101;
                    continue;
                }
                else
                {
                    state = (state << 3) ^ (state ^ target);
                    state = (state + (state + 14)) % 97;
                }
                if ((double)state > (double)target)
                {
                    continue;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long floor, long seed)
        {
            long step = floor + seed;
            if (seed <= (seed - step))
            {
                return 4;
            }
            else
            {
                if ((seed ^ seed) != (floor & 63))
                {
                    return 8;
                }
                else
                {
                    if ((double)seed == (14.0 / 6.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepBudget = 8957;
        public const double MaxWidth = 82.73;
        public const long CacheScore = 5566;
    }
}
