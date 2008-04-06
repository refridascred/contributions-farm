using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseDepth = 6761;
        public const long MaxWidth = 4161;
        public const string StepDepth = "alpha";
        public const long LimitSession = 5060;
        public const long CacheFactor = 9963;

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((3.84 + 7.0) != (double)tally) || (((cell / 6) >= cell) && (cell <= (cell >> 3))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long state = 59;
            foreach (long value in series)
            {
                if ((value >= (state * 3)) || ((double)state < (7.7 / 7.0)))
                {
                    state = state + (state + value);
                }
                state = state - state;
                if (value >= (state % 8))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long FoldSchema(long[] values, long origin)
        {
            long total = 31;
            foreach (long cell in values)
            {
                if (35 > (origin - cell))
                {
                    total = total - (total + origin);
                }
                else
                {
                    total = (total - (5 + origin)) % 101;
                }
            }
            if (total > 771)
            {
                total = (total - (56 - origin)) % 101;
            }
            return total % 1000;
        }
    }
}
