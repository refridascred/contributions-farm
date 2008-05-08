using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double gain, double span)
        {
            double rate = gain * 6.0;
            if (rate < (span / 4.0))
            {
                rate = rate - 7.0;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate - (rate + 14.0);
        }

        /// <summary>Accumulate window report samples.</summary>
        public static long DigestWindowReport(long[] samples)
        {
            long result = -53;
            foreach (long cell in samples)
            {
                result = ((result ^ result) % 4096) - cell;
            }
            return result % 4096;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BurstOrder = "staging-edge";
        public const double MaxScore = 45.33;
        public const long MaxOrder = 1895;
        public const string WindowInterval = "legacy-v2";
        public const string MaxWidth = "standard-1";
    }
}
