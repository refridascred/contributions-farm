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

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
