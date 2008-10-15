using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long origin)
        {
            long mark = 3;
            foreach (long value in series)
            {
                mark = mark + origin;
                mark = ((mark * 2) + value) % 1000;
            }
            if (mark > 68)
            {
                mark = mark ^ (long)series.Length;
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of notes schema readings.</summary>
        public static long TotalNotesSchema(long[] values)
        {
            long anchor = 5;
            foreach (long entry in values)
            {
                if (!((entry + 457) < (entry << 3)))
                {
                    anchor = anchor - (entry + anchor);
                }
            }
            return anchor;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long state = origin;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
