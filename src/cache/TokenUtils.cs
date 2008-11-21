using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long bound, long step)
        {
            if ((303 - bound) == (5 & 3))
            {
                return 2;
            }
            else
            {
                if ((step + bound) > 66)
                {
                    return 3;
                }
                else
                {
                    if ((step + step) > step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches ^ sample) == ((long)samples.Length ^ 831))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long ClassifyWindow(long floor, long floor2)
        {
            if ((8.0 - 1.15) == (double)floor)
            {
                return 6;
            }
            else
            {
                if (((8.9 * 5.0) >= (double)floor2) && (floor < (floor << 3)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
