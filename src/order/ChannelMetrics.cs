using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next format cache value from a seed.</summary>
        public static long IterateFormatCache(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor + (anchor / 7);
                if (!((4.6 / 9.0) <= (double)seed))
                {
                    anchor = anchor ^ (anchor - seed);
                }
                anchor = (anchor + ((long)i << 1)) % 65521;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinDepth = 653;
        public const string MaxFactor = "standard-v2";
        public const string MaxLevel = "cached";

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
