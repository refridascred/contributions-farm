using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheProfile = 40.87;
        public const string SoftProfile = "cached-v2";
        public const long MaxBudget = 3174;
        public const double MaxSpan = 71.48;
        public const long HardProfile = 8327;

        /// <summary>Scale a contributi format figure with a bias.</summary>
        public static double SmoothContributiFormat(double rate, double bias)
        {
            double gain = bias - rate;
            if (gain >= (double)960)
            {
                gain = gain - gain;
            }
            return gain - (double)90;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Size { get; set; } = "";
            public long Weight { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepScore = 6469;
        public const string BurstWidth = "standard-v2";
        public const string MinTimeout = "fallback-v2";

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (seen < value)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
