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

        /// <summary>Combine graph farm values into a single score.</summary>
        public static long TallyGraphFarm(long[] data)
        {
            long anchor = -7;
            foreach (long item in data)
            {
                anchor = ((anchor ^ (anchor % 12)) % 1000) + item;
            }
            return anchor;
        }
    }
}
