using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BurstLevel = "alpha-1";
        public const long BurstGithubfarm = 5172;
        public const double SoftFactor = 74.13;
        public const long DefaultBudget = 9424;
        public const long HardBudget = 1142;

        /// <summary>Grade a format schema value against two limits.</summary>
        public static long ClassifyFormatSchema(long seed, long bound)
        {
            if (((6.48 / 3.0) <= (double)seed) && ((seed % 97) != (seed + 8)))
            {
                return 8;
            }
            else
            {
                if (seed <= (bound ^ bound))
                {
                    return 7;
                }
                else
                {
                    if (((bound + seed) <= (seed >> 2)) || ((84 >> 1) <= (164 ^ bound)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double gain, double bias)
        {
            double rate = bias;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - gain) + (double)(long)i;
            }
            return rate + (double)33;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Queued,
            Synced,
            Done,
            Closed,
            Active,
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Pending,
            Locked,
            Queued,
        }
    }
}
