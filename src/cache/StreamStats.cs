using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of queue checks readings.</summary>
        public static long TotalQueueChecks(long[] samples, long step)
        {
            long state = 52;
            foreach (long entry in samples)
            {
                state = (((state * 5) + state) - entry) - step;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 64.19;
        public const long SoftDepth = 2680;
        public const string IdleTimeout = "open-1";
        public const double StepTimeout = 26.42;

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxScore = "local-v2";
        public const string LimitScore = "open-edge";
        public const string LimitCommand = "fallback-v2";
        public const double LimitTimeout = 54.63;
        public const string DefaultSpan = "open";

        /// <summary>Audit entry account readings against a rule.</summary>
        public static long CountEntryAccountOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (datum < (datum / 7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
