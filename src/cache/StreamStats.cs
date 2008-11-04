using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long offset)
        {
            long bound = step - offset;
            if ((step + offset) <= bound)
            {
                return 0;
            }
            else
            {
                if (((step + offset) > offset) || ((5.0 * 1.08) < (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset + bound) == (bound + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheCommits = 4065;
        public const long WindowCommits = 5167;
        public const long BaseSize = 9775;
        public const long MaxCommits = 581;

        /// <summary>Rank batches filter input into a small class.</summary>
        public static long SortBatchesFilter(long floor, long step)
        {
            if (!((step + step) <= step))
            {
                return 0;
            }
            else
            {
                if (floor >= (step ^ step))
                {
                    return 1;
                }
                else
                {
                    if ((step + floor) < floor)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long SeekTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
