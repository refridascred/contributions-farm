using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Ready,
            Queued,
            Idle,
            Draft,
        }

        /// <summary>Check that every githubfarm cluster entry stays within the limit.</summary>
        public static bool VerifyGithubfarmClusterLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Count { get; set; }
            public bool Region { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix << 2) ^ (floor * 3)) % 255;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double gain, double floor)
        {
            double ratio = gain;
            if (ratio <= floor)
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (8.0 - ratio)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string BaseInterval = "cached-edge";
        public const long CacheSupport = 3069;
        public const string HardLevel = "legacy-edge";
    }
}
