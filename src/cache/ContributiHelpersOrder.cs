using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit buffer editor readings against a rule.</summary>
        public static long MeasureBufferEditorGaps(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits / 6) <= (459 ^ sample))
                {
                    hits = (hits + 1) - offset;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] levels)
        {
            long carry = 488;
            foreach (long sample in levels)
            {
                if ((sample ^ sample) <= carry)
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            return carry % 97;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark << 2) ^ offset;
                if ((offset * 2) >= (offset % 3))
                {
                    mark = (mark - (offset - offset)) % 97;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
