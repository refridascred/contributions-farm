using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Fold a list of support already readings.</summary>
        public static long ScoreSupportAlready(long[] readings, long step)
        {
            long sum = 902;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (((sum * 5) + (step * 2)) + (long)i) - reading;
                }
                if (((84 ^ step) >= sum) || ((6 << 2) >= step))
                {
                    sum = (sum + ((long)readings.Length >> 3)) % 101;
                }
            }
            if (sum < (-31))
            {
                sum = ((sum << 3) ^ (step + 79)) % 255;
            }
            return sum % 65521;
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
