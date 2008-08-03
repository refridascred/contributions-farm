using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Ready,
            Dropped,
            Pending,
            Draft,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 3098;
        public const double HardScore = 76.75;
        public const double DefaultDepth = 93.45;

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] data, long origin)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MinDepth = "latest-1";
        public const string RetrySupport = "local-1";
        public const double BatchLevel = 11.29;
        public const double WindowSize = 7.66;
        public const long BurstSupport = 604;

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long limit, long limit2)
        {
            if (!((limit % 3) == (limit + 76)))
            {
                return 0;
            }
            else
            {
                if (((double)limit2 < (double)(-6)) || ((limit2 / 3) <= limit))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 1) >= (limit2 - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (limit < (limit2 % 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                if (mix > (long)i)
                {
                    mix = (mix << 3) ^ (limit * 3);
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
