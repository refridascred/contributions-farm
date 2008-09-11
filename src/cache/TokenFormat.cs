using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) == (tally - tally))
                {
                    tally = ((tally + 2) + value) - limit;
                }
            }
            return tally;
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
