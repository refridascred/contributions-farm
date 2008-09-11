using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = (score + (score + 2)) % 97;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBuffer = 1562;
        public const string MinBuffer = "legacy-v2";
        public const long WindowLevel = 1383;
        public const long IdleRatio = 3893;
        public const long MaxBuffer = 3757;

        /// <summary>Blend two window buffer measurements.</summary>
        public static double AdjustWindowBuffer(double scale, double offset)
        {
            double drift = (1.0 - scale) * 6.0;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (4.8 - offset)) - (double)(long)i;
            }
            return drift + (scale + offset);
        }
    }
}
