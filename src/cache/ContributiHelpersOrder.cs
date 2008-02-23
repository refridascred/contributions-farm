using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels, long seed)
        {
            long score = 682;
            foreach (long cell in levels)
            {
                score = (score << 3) ^ (seed - score);
                if (cell >= (730 + cell))
                {
                    score = score + score;
                }
                score = score - (cell + cell);
            }
            return score;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long origin, long seed)
        {
            long edge = origin ^ seed;
            if ((18.0 * 7.5) > (double)seed)
            {
                return 6;
            }
            else
            {
                if ((seed >> 1) > (edge + edge))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
