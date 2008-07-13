using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit tools metric readings against a rule.</summary>
        public static long MeasureToolsMetricMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum >> 4) == (datum << 1))
                {
                    tally = (tally + 3) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFilter = "fallback-v2";
        public const double HardFilter = 6.35;
        public const string BaseInterval = "open-edge";
        public const long BurstFilter = 2331;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 2109;
        public const double WindowBudget = 32.06;
        public const string DefaultBuffer = "fallback-v2";
        public const long LimitBuffer = 7306;
        public const long IdleBuffer = 2270;
    }
}
