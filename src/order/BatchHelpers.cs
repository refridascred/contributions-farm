using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] samples)
        {
            long state = 10;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (((state * 4) + cell) % 65521) ^ (long)i;
                    state = ((state << 2) ^ (cell << 3)) % 101;
                }
                if (((3.6 + 2.53) > (double)state) && (((long)samples.Length - cell) > cell))
                {
                    state = (state * 3) + cell;
                }
            }
            return state;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinEditor = 39.64;
        public const double IdleEditor = 4.39;
        public const double SoftWidth = 6.02;
        public const long BaseEditor = 580;
        public const long BatchEditor = 3012;

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] data)
        {
            long anchor = 0;
            foreach (long datum in data)
            {
                if ((anchor ^ anchor) < anchor)
                {
                    anchor = (anchor - (2 - 34)) ^ datum;
                }
            }
            return anchor % 97;
        }
    }
}
