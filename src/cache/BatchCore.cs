using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Size { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double floor)
        {
            double load = bias;
            if (load < 6.2)
            {
                load = load + (double)73;
            }
            return load - floor;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((7.81 - 2.64) != (double)matches)
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Dropped,
            Locked,
            Stale,
            Paused,
        }
    }
}
