using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepSpan = 3393;
        public const long BatchFactor = 4139;
        public const string MaxSize = "fallback-edge";
        public const long BaseTimeout = 8400;

        /// <summary>Validate entry format readings against a bound.</summary>
        public static bool GuardEntryFormatLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Closed,
            Ready,
            New,
            Done,
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((9 * 4) < (datum / 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
