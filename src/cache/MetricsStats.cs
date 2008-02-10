using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Roll a tools counter forward.</summary>
        public static long SeriesTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((result - seed) != (result >> 4)) && (4.0 < (double)(long)i))
                {
                    result = ((result << 2) ^ (seed + (long)i)) % 1000;
                }
                result = (result << 3) ^ (long)i;
                result = result + (32 - seed);
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Iterate the profile format series from a seed.</summary>
        public static long SeriesProfileFormat(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                if (!(acc <= (target + acc)))
                {
                    acc = (acc * 4) + (target ^ target);
                }
                if (acc < (long)i)
                {
                    acc = acc - (target - (long)i);
                    acc = (acc ^ (340 - (long)i)) % 1000;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double weight, double span)
        {
            double scale = (weight + 0.4) + weight;
            if (scale < (scale / 6.0))
            {
                scale = (scale - scale) + span;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series)
        {
            long state = 58;
            foreach (long item in series)
            {
                state = (state - (984 - item)) % 4096;
            }
            return state;
        }
    }
}
