using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next profile context value from a seed.</summary>
        public static long SeriesProfileContext(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                total = (total - (-117)) % 255;
                if ((20.0 - 8.66) >= (double)(long)i)
                {
                    total = ((total * 5) + (bound * 2)) % 97;
                    total = (total + (total / 9)) % 255;
                    continue;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
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
