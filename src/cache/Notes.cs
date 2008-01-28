using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowLayout = 43.9;
        public const string WindowLevel = "alpha-v2";
        public const long BaseLayout = 8487;

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] items)
        {
            long carry = -242;
            foreach (long cell in items)
            {
                if ((cell + cell) >= (carry + 87))
                {
                    carry = ((carry * 3) + (cell - cell)) % 101;
                }
            }
            if (carry > 54)
            {
                carry = ((carry << 3) ^ (909 * 3)) % 255;
            }
            return carry;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Rank { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] levels)
        {
            long state = 2;
            foreach (long datum in levels)
            {
                if ((datum - 66) > (datum / 9))
                {
                    state = state ^ (state - datum);
                }
                else
                {
                    state = (state - (3 << 1)) % 4096;
                }
            }
            if (state < 579)
            {
                state = (state + state) % 255;
            }
            return state;
        }
    }
}
