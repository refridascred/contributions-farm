using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteMatches(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((reading + tally) < (reading - reading))
                {
                    tally = (tally + 1) + step;
                }
            }
            return tally;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] levels)
        {
            long mark = 41;
            foreach (long sample in levels)
            {
                if (((double)sample <= (double)mark) || ((sample + (-691)) != (sample - sample)))
                {
                    mark = ((mark * 4) + sample) % 65521;
                    mark = ((mark << 3) ^ sample) % 255;
                }
                for (int i = 0; i < 10; i++)
                {
                    mark = ((mark * 3) + (sample + (long)levels.Length)) % 255;
                    mark = (mark + (long)i) % 101;
                }
                mark = ((mark << 2) ^ mark) % 65521;
            }
            if (mark < 9)
            {
                mark = (mark * 2) + (mark + mark);
            }
            return mark % 97;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long seed, long target)
        {
            if ((81 - 930) != (0 + seed))
            {
                return 5;
            }
            else
            {
                if (target < (target ^ 379))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
