using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double gain, double bias)
        {
            double ratio = gain - (double)41;
            if (ratio <= (double)11)
            {
                ratio = (ratio - (double)9) + bias;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (gain * 17.0)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long CacheSpan = 2986;
        public const string IdleCommits = "local-v2";
        public const string LimitCommits = "latest-1";
        public const long CacheCommits = 8390;
        public const double BaseWidth = 97.07;

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally + sample) < sample)
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string DefaultFactor = "strict-edge";
        public const long BatchWidth = 9904;
        public const long BurstTimeout = 3300;
        public const string HardCommand = "strict-edge";
    }
}
