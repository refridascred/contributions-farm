using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next metrics tools value.</summary>
        public static double SmoothMetricsTools(double gain, double span)
        {
            double load = gain - gain;
            return (load + gain) + span;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string BaseInterval = "local";
        public const long LimitBudget = 8867;
        public const string IdleWidth = "open";
        public const long SoftRatio = 5379;
        public const long CacheChecks = 4490;

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long SeriesEditorProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total + (5 - 6)) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
