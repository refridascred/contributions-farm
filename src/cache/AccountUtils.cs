using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            New,
            Idle,
            Locked,
            Failed,
            Synced,
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public bool Mode { get; set; }
            public string Region { get; set; } = "";
            public long Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Validate contributi already readings against a bound.</summary>
        public static bool GuardContributiAlreadyLimits(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
