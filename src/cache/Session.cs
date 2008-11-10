using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Ready,
            Stale,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long ScoreCache(long[] levels)
        {
            long total = 84;
            foreach (long sample in levels)
            {
                if ((sample << 1) >= (total & 127))
                {
                    total = total - (5 / 8);
                }
            }
            return total;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Flag { get; set; } = "";
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two filter metric measurements.</summary>
        public static double ProjectFilterMetric(double rate, double floor)
        {
            double scale = (double)(886 % 100);
            if (scale <= (double)5)
            {
                scale = (scale - (double)380) - rate;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (floor * 3.8);
        }
    }
}
