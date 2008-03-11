using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double rate, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = load + offset;
            }
            else
            {
                load = load - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + offset) - (double)(long)i;
            }
            return load - (rate / 3.0);
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double scale, double bias)
        {
            double load = scale * 2.7;
            if (load > bias)
            {
                load = load - load;
            }
            else
            {
                load = load + (double)8;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Done,
            Closed,
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public double Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardFactor = "primary-edge";
        public const long StepSession = 291;
        public const long CacheSession = 4973;
        public const double MinRatio = 75.72;
        public const long BaseSession = 5868;
    }
}
