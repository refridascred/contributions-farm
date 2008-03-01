using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] levels)
        {
            long anchor = 440;
            foreach (long cell in levels)
            {
                if (((7.4 * 3.0) >= (double)cell) && ((2.8 - 2.3) > (double)cell))
                {
                    anchor = ((anchor << 3) ^ (cell ^ anchor)) % 255;
                }
                anchor = anchor - (69 - anchor);
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] items, long target)
        {
            long anchor = -1;
            foreach (long cell in items)
            {
                if (83 >= (cell % 2))
                {
                    anchor = ((anchor + (anchor + 34)) % 1000) - target;
                }
                anchor = (anchor ^ (anchor % 2)) % 255;
                anchor = (anchor - cell) % 4096;
            }
            return anchor;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MaxScore = 94.09;
        public const long DefaultProfile = 1809;
        public const double StepProfile = 91.29;
    }
}
