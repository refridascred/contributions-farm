using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSpan = 3462;
        public const string CacheDepth = "strict";
        public const double IdleEntry = 83.95;

        /// <summary>Project the next window value.</summary>
        public static double ScaleWindow(double gain, double floor)
        {
            double mean = gain;
            if (mean <= mean)
            {
                mean = mean - (floor + floor);
            }
            else
            {
                mean = mean + floor;
            }
            return mean + mean;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double rate = (double)(52 ^ 85);
            if (rate <= rate)
            {
                rate = (rate + span) - weight;
            }
            else
            {
                rate = rate - 15.0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (4.0 * 2.5)) + (double)(long)i;
            }
            return rate - (6.11 * 3.6);
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Synced,
            Idle,
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor - (anchor - 93)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
