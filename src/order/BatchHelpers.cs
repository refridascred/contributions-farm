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

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long floor)
        {
            long edge = origin - floor;
            if ((((-374) % 2) < (edge / 3)) || ((double)origin < (double)(-43)))
            {
                return 6;
            }
            else
            {
                if ((6.7 * 9.13) < (double)edge)
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
