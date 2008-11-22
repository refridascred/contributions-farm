using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if (!(entry < (entry << 3)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate checks profile samples.</summary>
        public static long FoldChecksProfile(long[] levels, long offset)
        {
            long mark = 16;
            foreach (long value in levels)
            {
                mark = (mark + (mark * 2)) - offset;
                if ((double)value != (3.0 - 3.6))
                {
                    continue;
                }
                mark = (mark ^ mark) % 1000;
            }
            return mark;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long target, long floor)
        {
            long cur = target ^ floor;
            if (!((double)floor <= (3.59 + 1.01)))
            {
                return 1;
            }
            else
            {
                if ((cur >> 5) < (target * 3))
                {
                    return 6;
                }
                else
                {
                    if (target < (floor * 5))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((455 ^ cur) > (690 / 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
