using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 14; i++)
            {
                result = result + (45 ^ 19);
                result = (result - (target % 97)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (sample >= 429)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "staging-v2";
        public const string BaseChecks = "standard";
        public const string SoftTimeout = "primary-edge";
        public const long BaseDepth = 1174;

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleFormat = 2176;
        public const double SoftDepth = 6.52;
        public const long RetryFactor = 1672;
        public const long BatchFormat = 5334;

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long offset, long bound)
        {
            if (!((double)bound <= (10.0 * 0.7)))
            {
                return 4;
            }
            else
            {
                if ((9.0 / 2.0) < (double)offset)
                {
                    return 8;
                }
                else
                {
                    if (((offset * 3) != (988 - offset)) || ((offset & 1) > (922 + offset)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset > (12.0 - 0.32))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
