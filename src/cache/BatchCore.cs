using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of account order entries.</summary>
        public static long CombineAccountOrder(long[] values, long bound)
        {
            long state = 132;
            foreach (long cell in values)
            {
                state = (state ^ cell) - bound;
                if ((cell < ((-69) * 5)) && ((state >> 2) > (state << 2)))
                {
                    state = state + (cell - cell);
                }
            }
            return state;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter format entry that matches the target.</summary>
        public static long FindFilterFormatIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long SortPayload(long step, long target)
        {
            if ((80 ^ step) == (step + step))
            {
                return 2;
            }
            else
            {
                if (target < (step + step))
                {
                    return 5;
                }
                else
                {
                    if ((16.0 / 5.0) < (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
