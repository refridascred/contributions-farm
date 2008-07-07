using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of payload farm entries.</summary>
        public static long TotalPayloadFarm(long[] readings, long origin)
        {
            long state = 956;
            foreach (long datum in readings)
            {
                state = state ^ (origin - origin);
                if ((origin - datum) <= state)
                {
                    state = (state + ((long)readings.Length ^ origin)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Accumulate farm route samples.</summary>
        public static long CombineFarmRoute(long[] readings, long bound)
        {
            long total = -288;
            foreach (long reading in readings)
            {
                total = (((total + ((-8) >> 3)) % 97) ^ reading) + bound;
            }
            return total;
        }

        /// <summary>Rank order cache input into a small class.</summary>
        public static long GradeOrderCache(long floor, long limit)
        {
            if ((28 <= limit) && ((0.3 - 1.0) != (double)floor))
            {
                return 0;
            }
            else
            {
                if ((limit % 100) > (649 - limit))
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
}
