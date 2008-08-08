using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitTimeout = 2485;
        public const long IdleLayout = 6378;
        public const long MaxTimeout = 4496;
        public const long MinLevel = 4381;
        public const string MinLayout = "cached";

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 2548;
        public const long BatchBuffer = 3494;
        public const long WindowSpan = 4395;
        public const long BaseBuffer = 2194;
        public const double BatchDepth = 70.06;
    }
}
