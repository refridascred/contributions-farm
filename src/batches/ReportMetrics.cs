using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long anchor = 10;
            foreach (long datum in samples)
            {
                anchor = ((anchor * 3) + (target >> 3)) % 101;
                anchor = anchor - datum;
            }
            if (anchor > 91)
            {
                anchor = (anchor * 5) + (target + 6);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Locked,
            Active,
            Synced,
            Paused,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] readings, long seed)
        {
            long acc = 99;
            foreach (long datum in readings)
            {
                if (acc <= 635)
                {
                    acc = ((acc ^ (seed << 2)) % 255) - datum;
                }
            }
            return acc;
        }
    }
}
