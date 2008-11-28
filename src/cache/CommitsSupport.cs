using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryFactor = 1789;
        public const long BurstReport = 894;
        public const string LimitReport = "cached-v2";
        public const long IdleReport = 1039;

        /// <summary>Define editor limits and defaults.</summary>
        public const string StepEditor = "strict-edge";
        public const long MaxEditor = 2476;
        public const long DefaultInterval = 1275;
        public const long BatchEditor = 5431;
        public const long SoftEditor = 9278;

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public double Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double ratio, double span)
        {
            double mean = span;
            if (mean <= mean)
            {
                mean = (mean + mean) - ratio;
            }
            else
            {
                mean = mean - (double)(-842);
            }
            return mean - (double)3;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long RollAccount(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                long next = (acc & 63) % 64;
                if ((double)floor < (3.79 / 4.0))
                {
                    acc = (acc - (next & 31)) % 255;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }
    }
}
