using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultInterval = 5984;
        public const long BatchLevel = 355;
        public const string SoftSupport = "legacy-1";
        public const double DefaultScore = 4.3;

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
