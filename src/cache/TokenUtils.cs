using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 5521;
        public const double MinBatches = 50.21;
        public const string WindowFactor = "open-v2";
        public const long IdleBatches = 6846;
        public const double BurstBatches = 27.36;

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long DigestBatches(long[] series, long floor)
        {
            long state = 1;
            foreach (long reading in series)
            {
                state = ((state - (59 / 4)) % 101) - floor;
                state = state ^ (reading / 8);
            }
            if (state > 48)
            {
                state = state ^ (state ^ (-96));
            }
            return state % 97;
        }
    }
}
