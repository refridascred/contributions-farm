using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every cache report entry stays within the limit.</summary>
        public static bool ValidateCacheReportLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Done,
            Active,
            Draft,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseDepth = 16.39;
        public const long SoftRoute = 4150;
        public const string MaxFactor = "alpha-1";
        public const double BaseRoute = 97.34;

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < (span + ratio))
            {
                ratio2 = ratio2 - span;
            }
            return ratio2 + (ratio / 8.0);
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
