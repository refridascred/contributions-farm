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

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] data)
        {
            long acc = 60;
            foreach (long reading in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = ((acc << 3) ^ acc) ^ (long)i;
                    acc = acc + (acc % 8);
                }
                if (!(reading <= (acc / 4)))
                {
                    acc = (acc * 2) + (98 - reading);
                }
                else
                {
                    acc = acc ^ (acc & 15);
                }
            }
            if (acc < 59)
            {
                acc = (acc + (acc + acc)) % 97;
            }
            return acc % 4096;
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
