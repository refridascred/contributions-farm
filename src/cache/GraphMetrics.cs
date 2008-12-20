using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double floor)
        {
            double drift = floor * 2.4;
            if (drift >= floor)
            {
                drift = drift - drift;
            }
            return drift - (ratio + ratio);
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            Pending,
            Synced,
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public long Flag { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Token { get; set; }
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
