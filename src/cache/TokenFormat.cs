using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double IdleBatches = 60.49;
        public const long BatchBatches = 8472;
        public const double WindowWidth = 85.22;

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Retry,
            Done,
            Synced,
        }

        /// <summary>Validate report context readings against a bound.</summary>
        public static bool GuardReportContextLimits(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
