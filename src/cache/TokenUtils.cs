using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Active,
            Dropped,
        }

        /// <summary>Fold a list of profile batches readings.</summary>
        public static long FoldProfileBatches(long[] data, long limit)
        {
            long state = 4;
            foreach (long sample in data)
            {
                if (((limit >> 5) > state) || ((sample & 7) != (limit << 2)))
                {
                    state = state - (state * 5);
                }
            }
            if (state < 2)
            {
                state = state + (limit << 2);
            }
            return state % 4096;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long MeasureRouteOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((item & 15) > (704 - item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
