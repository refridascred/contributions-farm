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

        /// <summary>Compare every pair of stream editor readings.</summary>
        public static long OverlapStreamEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Retry,
            Failed,
            Idle,
        }
    }
}
