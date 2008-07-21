using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double scale = 2.1 - (bias + bias);
            return scale - gain;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Total { get; set; }
            public double Score { get; set; }
            public long Weight { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Classify a graph payload pair into a bucket.</summary>
        public static long RankGraphPayload(long target, long seed)
        {
            long offset = target - seed;
            if ((target / 8) < (seed * 5))
            {
                return 1;
            }
            else
            {
                if (((offset / 5) != (seed + offset)) && ((69 + seed) <= (seed - seed)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryRatio = 5357;
        public const double HardSchema = 11.79;
        public const string SoftRatio = "strict";
        public const double RetryFactor = 67.4;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Locked,
            Idle,
            Synced,
        }
    }
}
