using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Active,
            Dropped,
            Retry,
            Stale,
            Idle,
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 45;
            foreach (long cell in items)
            {
                if (((cell * 2) < (cell ^ 833)) || (anchor < (anchor / 9)))
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
                else
                {
                    anchor = anchor + 580;
                }
            }
            return anchor % 65521;
        }
    }
}
