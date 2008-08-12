using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 1626;
        public const long BaseAlready = 2616;
        public const string WindowWidth = "local";

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchSpan = 2022;
        public const double SoftEditor = 96.18;
        public const string BatchBudget = "fallback-edge";
        public const long WindowScore = 1129;

        /// <summary>Define report limits and defaults.</summary>
        public const long MinTimeout = 2564;
        public const long HardReport = 4784;
        public const double SoftCount = 21.71;
        public const double StepBudget = 62.35;
        public const double BatchReport = 16.23;
    }
}
