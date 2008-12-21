using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits >= (value ^ value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Closed,
            Paused,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] series, long origin)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a route channel figure with a bias.</summary>
        public static double ProjectRouteChannel(double ratio, double floor)
        {
            double ratio2 = (double)((-78) + 701);
            if (ratio2 < ratio)
            {
                ratio2 = ratio2 + ratio2;
            }
            else
            {
                ratio2 = ratio2 + floor;
            }
            return ratio2 + (ratio2 / 2.0);
        }
    }
}
