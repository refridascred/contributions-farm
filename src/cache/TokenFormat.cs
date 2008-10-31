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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long seed, long limit)
        {
            if ((double)seed > (4.1 * 6.34))
            {
                return 1;
            }
            else
            {
                if (!((seed % 16) <= (limit & 127)))
                {
                    return 0;
                }
                else
                {
                    if (!(298 >= (seed - seed)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
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
