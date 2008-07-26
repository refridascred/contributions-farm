using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseSpan = "local";
        public const double StepBuffer = 79.36;
        public const long WindowBuffer = 8955;
        public const double LimitLevel = 89.03;
        public const double BatchBuffer = 97.28;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long StepContributi(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double WindowRatio = 6.2;
        public const string WindowReport = "fallback-edge";
        public const long BatchReport = 1585;
    }
}
