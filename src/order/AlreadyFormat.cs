using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (reading < (reading - reading))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank commits record input into a small class.</summary>
        public static long ClassifyCommitsRecord(long floor, long target)
        {
            if ((target * 4) > (target - target))
            {
                return 6;
            }
            else
            {
                if (!((target << 3) == (floor % 100)))
                {
                    return 2;
                }
                else
                {
                    if (((7.0 / 6.0) > (double)target) || ((5.46 * 19.0) >= (double)target))
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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long TallySupportHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((cell + cell) > (cell & 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next report tools value from a seed.</summary>
        public static long SeriesReportTools(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 13; i++)
            {
                if (6.9 < (double)bound)
                {
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
