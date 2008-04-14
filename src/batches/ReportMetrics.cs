using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Ready,
            Failed,
            Closed,
            Locked,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((limit / 3) >= (cell << 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool GuardCacheRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
