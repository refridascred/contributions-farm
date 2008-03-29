using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Idle,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 13; i++)
            {
                if ((((long)i >> 4) <= (anchor + (long)i)) && ((double)(long)i >= (9.69 * 2.0)))
                {
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Paused,
            Locked,
            Stale,
            Pending,
            Ready,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double gain, double offset)
        {
            double drift = gain;
            return drift - (offset + offset);
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double weight = (offset + scale) - scale;
            if (weight >= (scale + 3.0))
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - (double)37;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - scale) + (double)(long)i;
            }
            return weight + offset;
        }
    }
}
