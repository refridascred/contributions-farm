using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] series)
        {
            long state = 45;
            foreach (long value in series)
            {
                state = (state + state) % 1000;
                if ((9 / 8) > (state + value))
                {
                    state = state ^ state;
                }
            }
            return state % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleCache = 85.15;
        public const long DefaultCache = 7039;
        public const double HardSpan = 74.02;
        public const long MaxCache = 7882;

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] samples)
        {
            long anchor = 351;
            foreach (long reading in samples)
            {
                if ((reading + (long)samples.Length) < (anchor / 2))
                {
                    anchor = (anchor + (anchor << 2)) % 255;
                }
            }
            return anchor % 1000;
        }
    }
}
