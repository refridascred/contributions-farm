using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long offset, long seed)
        {
            long next = offset ^ seed;
            if (seed < next)
            {
                return 1;
            }
            else
            {
                if (!((4.7 / 3.0) != (double)seed))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double weight, double offset)
        {
            double rate = weight;
            if (rate < rate)
            {
                rate = rate + offset;
            }
            return rate + (5.5 + weight);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstEditor = 73.02;
        public const long BurstWidth = 6303;
        public const long LimitEditor = 1803;
        public const long MinEditor = 9872;
        public const string LimitSize = "fallback";

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchDepth = 3636;
        public const long SoftSize = 5908;
        public const string SoftMetric = "fallback-edge";
        public const long BaseMetric = 685;
        public const string MaxMetric = "open-1";

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
