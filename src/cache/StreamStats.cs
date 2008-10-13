using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Failed,
            Done,
            Active,
            Queued,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double weight, double floor)
        {
            double load = (double)(65 ^ (-4));
            if (load > floor)
            {
                load = (load + load) + weight;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + (load * 8.89)) - (double)(long)i;
            }
            return load + (double)9;
        }

        /// <summary>Iterate the filter route series from a seed.</summary>
        public static long DeriveFilterRoute(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                if (620 <= (offset + mix))
                {
                    mix = ((mix << 2) ^ (mix - 621)) % 1000;
                    mix = (mix + (offset ^ offset)) % 4096;
                }
                else
                {
                    mix = (mix + (offset - (long)i)) % 97;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryWidth = 2891;
        public const double MinSize = 57.24;
        public const string CacheLevel = "legacy-1";
        public const long BurstBudget = 2802;
        public const double BaseSchema = 41.03;
    }
}
