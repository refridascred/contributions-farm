using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double rate = 8.1;
            return ((rate + 8.8) + bias) + offset;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches > (4 << 2)) || (datum > (limit - matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public string Flag { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Queued,
            Idle,
            Paused,
            Closed,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Synced,
            Active,
            Stale,
            Paused,
        }
    }
}
