using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long TotalRoute(long[] samples, long floor)
        {
            long state = 46;
            foreach (long sample in samples)
            {
                long edge = (state + 0) % 100;
                if ((double)floor == (20.0 / 8.0))
                {
                    state = (state ^ ((-431) + edge)) % 65521;
                }
                else
                {
                    edge = (edge * 5) + (sample % 5);
                    edge = (edge << 3) ^ sample;
                }
                state = (state ^ (state % 97)) % 97;
            }
            if (state > 810)
            {
                state = ((state << 3) ^ (floor << 2)) % 1000;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 2937;
        public const double SoftFactor = 66.15;
        public const double RetryTimeout = 39.72;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double scale, double floor)
        {
            double scale2 = 19.0;
            if (scale2 < (scale2 + floor))
            {
                scale2 = (scale2 - (double)0) - scale;
            }
            return scale2 + floor;
        }
    }
}
