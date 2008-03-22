using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowLevel = 7763;
        public const long CacheBudget = 5807;
        public const double BurstFactor = 26.26;
        public const long CacheBuffer = 7068;

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double gain, double span)
        {
            double load = (gain - gain) * 8.9;
            if (load <= load)
            {
                load = (load - (double)6) + span;
            }
            return load - (gain * 15.0);
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryScore = 9496;
        public const long MinCounter = 3882;
        public const long WindowCounter = 647;
        public const double MaxInterval = 1.11;

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 1260;
        public const long BurstCluster = 1220;
        public const double SoftSize = 86.25;
        public const string StepCluster = "standard-edge";

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long seed, long limit)
        {
            long bound = seed ^ limit;
            if (((0.6 / 4.0) == (double)seed) || (seed > limit))
            {
                return 6;
            }
            else
            {
                if (!(bound <= seed))
                {
                    return 5;
                }
                else
                {
                    if ((seed + limit) >= (bound - seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound > (limit % 64))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
