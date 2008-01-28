using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (((reading / 9) > (reading ^ 75)) || (floor < (floor & 255)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long RankReport(long offset, long bound)
        {
            if ((16.0 - 7.98) != (double)bound)
            {
                return 1;
            }
            else
            {
                if ((offset >> 1) == (bound / 6))
                {
                    return 3;
                }
                else
                {
                    if (21 < (bound % 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(17.0 >= (double)bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next support farm value from a seed.</summary>
        public static long SeriesSupportFarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                if ((double)mark > 13.0)
                {
                    mark = (mark * 2) + (long)i;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
