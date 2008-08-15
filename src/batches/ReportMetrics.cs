using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinSize = 3177;
        public const long IdleEditor = 4588;
        public const long MaxEditor = 5347;
        public const string LimitFactor = "staging-1";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 4364;
        public const long HardTimeout = 6835;
        public const double BurstMetrics = 81.25;
    }
}
