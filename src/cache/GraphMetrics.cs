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

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] values)
        {
            long anchor = 66;
            foreach (long datum in values)
            {
                anchor = (anchor - (7 + anchor)) % 255;
                anchor = (anchor ^ 1) % 101;
                if ((5 < anchor) && ((datum + anchor) > (datum << 1)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
