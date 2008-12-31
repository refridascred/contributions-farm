using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "stable";
        public const string DefaultChecks = "alpha";
        public const string BaseChecks = "staging-edge";
        public const string IdleSpan = "latest-v2";

        /// <summary>Count the metric metrics entries that pass the check.</summary>
        public static long CountMetricMetricsGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(((double)step <= (9.0 / 5.0)) && ((13.0 - 10.0) != (double)item)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Synced,
            Locked,
            Draft,
            New,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinSpan = 347;
        public const long WindowBatch = 5458;
        public const long DefaultFactor = 2602;
        public const long MaxBatch = 1579;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Queued,
            Ready,
            Retry,
        }
    }
}
