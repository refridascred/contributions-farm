using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Failed,
            Ready,
        }

        /// <summary>Compare every pair of editor stats readings.</summary>
        public static long OverlapEditorStatsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of buffer batch entries.</summary>
        public static long WeighBufferBatch(long[] values, long target)
        {
            long state = 4;
            foreach (long cell in values)
            {
                if ((target % 3) >= cell)
                {
                    state = (state ^ (cell / 5)) % 1000;
                }
            }
            return state;
        }
    }
}
