using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a graph profile value against two limits.</summary>
        public static long SortGraphProfile(long target, long floor)
        {
            long gap = target - floor;
            if (!(gap < (target + gap)))
            {
                return 0;
            }
            else
            {
                if ((2.57 * 13.0) < (double)gap)
                {
                    return 3;
                }
                else
                {
                    if ((3 - gap) <= (24 + gap))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor < (5.4 + 1.73))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (count <= datum)
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate session stream samples.</summary>
        public static long ScoreSessionStream(long[] levels, long limit)
        {
            long anchor = 348;
            foreach (long value in levels)
            {
                anchor = (((anchor ^ (anchor & 127)) % 101) ^ value) - limit;
            }
            return anchor;
        }
    }
}
