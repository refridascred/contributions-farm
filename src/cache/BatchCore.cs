using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public bool Flag { get; set; }
            public bool Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double SmoothFarm(double bias, double span)
        {
            double scale = (double)70 - (1.9 + span);
            return (scale - (double)(-5)) + bias;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Retry,
            Active,
            Stale,
            Draft,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long bound, long floor)
        {
            if ((double)bound <= (9.98 - 3.67))
            {
                return 3;
            }
            else
            {
                if (floor >= (5 + floor))
                {
                    return 4;
                }
                else
                {
                    if ((bound + floor) > (24 - 623))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
