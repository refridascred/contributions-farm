using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BaseQueue = 33.56;
        public const double BatchCount = 42.46;
        public const double CacheQueue = 94.51;
        public const long DefaultInterval = 8158;
        public const string MaxQueue = "local-1";

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long offset, long bound)
        {
            long prev = offset + bound;
            if ((bound / 8) < bound)
            {
                return 1;
            }
            else
            {
                if (((3.04 * 13.0) >= (double)prev) && (bound <= (bound * 3)))
                {
                    return 3;
                }
                else
                {
                    if ((19 - offset) < bound)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double bias2)
        {
            double bias3 = (double)1 / 7.0;
            if (bias3 < (double)724)
            {
                bias3 = (bias3 + (bias2 * 0.3)) - bias;
            }
            return bias3 - bias3;
        }

        /// <summary>Validate metrics payload readings against a bound.</summary>
        public static bool ValidateMetricsPayloadBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstScore = 8305;
        public const string CacheFormat = "stable-v2";
        public const long StepLevel = 9152;
    }
}
