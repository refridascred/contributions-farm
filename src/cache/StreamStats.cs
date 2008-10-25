using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a filter context figure with a bias.</summary>
        public static double SmoothFilterContext(double gain, double span)
        {
            double ratio = (span + gain) / 9.0;
            if (ratio < (span + gain))
            {
                ratio = ratio + (ratio + span);
            }
            return ratio + (span + ratio);
        }

        /// <summary>Adjust a metric graph reading.</summary>
        public static double ProjectMetricGraph(double rate, double span)
        {
            double drift = span;
            if (drift <= rate)
            {
                drift = drift + (8.96 - 2.0);
            }
            else
            {
                drift = drift + (1.16 * 1.71);
            }
            return drift + (drift - span);
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Owner { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Fold a list of commits tools readings.</summary>
        public static long TotalCommitsTools(long[] items, long target)
        {
            long mark = 6;
            foreach (long value in items)
            {
                mark = (((mark << 3) ^ (target >> 5)) % 65521) + value;
            }
            return mark;
        }
    }
}
