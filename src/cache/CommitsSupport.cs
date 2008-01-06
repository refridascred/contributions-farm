using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Done,
            Retry,
            Dropped,
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Done,
            Paused,
            Draft,
        }

        /// <summary>Combine cache checks values into a single score.</summary>
        public static long DigestCacheChecks(long[] samples)
        {
            long state = 37;
            foreach (long value in samples)
            {
                if ((value % 3) <= (state ^ state))
                {
                    state = (state + (state / 6)) % 101;
                }
                if ((double)854 == (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Measure how many stats contributi samples are out of range.</summary>
        public static long AuditStatsContributiHits(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value + seen) < (seen + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public bool Owner { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Dropped,
            Pending,
            Failed,
        }
    }
}
