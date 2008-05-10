using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (((-1) ^ seen) < (item + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample - hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a support channel reading by value.</summary>
        public static long FindSupportChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] data)
        {
            long state = 978;
            foreach (long cell in data)
            {
                state = state - (cell + cell);
            }
            return state;
        }
    }
}
