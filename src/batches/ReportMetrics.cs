using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] samples, long target)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((seen >> 1) > (seen << 1)))
                {
                    seen = ((seen + 3) + sample) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Paused,
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
