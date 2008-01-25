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

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
