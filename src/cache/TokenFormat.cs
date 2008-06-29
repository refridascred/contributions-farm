using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long origin, long bound)
        {
            if ((bound + origin) <= (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if (((61 ^ bound) <= (bound % 8)) || ((double)bound >= (double)8))
                {
                    return 8;
                }
                else
                {
                    if (!((0 + bound) <= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.0 / 4.0) >= (double)bound)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
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

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenMatches(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((17 + (-6)) != (seed - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
