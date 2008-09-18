using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] items, long offset)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (!((offset & 127) == (offset % 7)))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Validate already layout readings against a bound.</summary>
        public static bool CheckAlreadyLayoutLimits(long[] items, long bound)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 4444;
        public const string MinProfile = "strict-edge";
        public const long RetryTimeout = 7899;
    }
}
