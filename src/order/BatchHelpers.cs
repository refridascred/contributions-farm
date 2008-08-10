using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long floor)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                anchor = (anchor - (anchor - item)) % 65521;
                if ((anchor % 100) == (anchor - floor))
                {
                    break;
                }
            }
            if (anchor < 63)
            {
                anchor = (anchor ^ (9 << 3)) % 1000;
            }
            return anchor;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Draft,
            New,
            Retry,
            Active,
            Failed,
        }
    }
}
