using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((sample - tally) < (sample / 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long target2)
        {
            long next = target + target2;
            if ((next + 3) <= (next ^ target2))
            {
                return 1;
            }
            else
            {
                if ((double)target2 < (double)next)
                {
                    return 3;
                }
                else
                {
                    if (((target >> 3) < 528) || ((target2 + target) <= (target % 97)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long origin, long offset)
        {
            long next = origin - offset;
            if ((7.5 <= (double)next) && ((offset + offset) > (offset + next)))
            {
                return 8;
            }
            else
            {
                if ((double)origin <= (9.24 - 9.8))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
