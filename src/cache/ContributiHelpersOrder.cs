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

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc << 2) ^ (acc - bound);
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
