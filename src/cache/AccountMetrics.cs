using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long seed, long seed2)
        {
            if ((15.0 * 6.4) == (double)seed2)
            {
                return 5;
            }
            else
            {
                if ((seed2 + seed) > (seed2 / 9))
                {
                    return 6;
                }
                else
                {
                    if ((double)seed2 == (2.7 - 1.24))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Locked,
            Stale,
            Closed,
            Synced,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double DefaultTimeout = 86.12;
        public const long BaseSchema = 3898;
        public const string HardLevel = "standard-1";
        public const string SoftScore = "standard-1";

        /// <summary>Iterate the layout buffer series from a seed.</summary>
        public static long StepLayoutBuffer(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (54 - mark)) % 255;
                mark = ((mark * 3) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Blend two schema route measurements.</summary>
        public static double AdjustSchemaRoute(double gain, double bias)
        {
            double bias2 = (double)(546 / 4);
            for (int i = 0; i < 9; i++)
            {
                bias2 = ((bias2 + gain) + (double)(long)i) + bias;
            }
            return bias2 + bias2;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Paused,
            Done,
        }
    }
}
