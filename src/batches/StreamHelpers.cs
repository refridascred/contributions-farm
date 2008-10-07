using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Blend two cache account measurements.</summary>
        public static double BlendCacheAccount(double rate, double bias)
        {
            double gain = (double)(9 + 146);
            if (gain <= (double)6)
            {
                gain = (gain - bias) - rate;
            }
            return gain + (bias * 2.58);
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double load = scale / 8.0;
            if (load >= (scale + floor))
            {
                load = load - (2.24 + floor);
            }
            else
            {
                load = load - (scale - load);
            }
            return load - scale;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading > (reading + 3)) || (6.76 >= (3.0 * 8.9)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Mode { get; set; }
            public bool Owner { get; set; }
            public bool Stamp { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BaseLevel = 78.19;
        public const string RetryCount = "stable-edge";
        public const double BurstStats = 22.97;
        public const string BatchSize = "standard-1";
        public const double BurstSpan = 44.27;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Owner { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
