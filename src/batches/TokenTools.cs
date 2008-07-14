using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!!(tally <= datum))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Stale,
            Pending,
            New,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long origin, long bound)
        {
            long step = origin + bound;
            if ((bound > origin) && ((860 << 1) < bound))
            {
                return 6;
            }
            else
            {
                if ((bound + step) <= (step + step))
                {
                    return 3;
                }
                else
                {
                    if ((double)origin == (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + 262) >= bound)
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
        }
    }
}
