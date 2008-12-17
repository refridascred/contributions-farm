using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long origin, long offset)
        {
            long next = origin ^ offset;
            if ((double)next != (2.0 / 9.0))
            {
                return 1;
            }
            else
            {
                if ((next * 3) != (origin - next))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long SeekQueueIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long BucketNotes(long bound, long seed)
        {
            if ((bound >> 5) == (seed - bound))
            {
                return 6;
            }
            else
            {
                if (((6.8 / 7.0) != (double)bound) || (5.9 > (double)seed))
                {
                    return 7;
                }
                else
                {
                    if (!((bound ^ seed) >= seed))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
