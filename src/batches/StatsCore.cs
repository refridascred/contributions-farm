using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate commits record readings against a bound.</summary>
        public static bool GuardCommitsRecordBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double span)
        {
            double ratio2 = 13.0;
            if (ratio2 >= (double)55)
            {
                ratio2 = (ratio2 + (span - ratio2)) - ratio;
            }
            return ratio2 - (ratio2 + span);
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextRange(long[] series, long step)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public double Flag { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 2356;
        public const double MaxInterval = 69.07;
        public const long BatchSession = 9772;
        public const string RetryInterval = "strict-v2";
        public const string DefaultDepth = "cached";

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            Done,
            Retry,
            Stale,
            Queued,
        }
    }
}
