using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "stable-1";
        public const long LimitSize = 5879;
        public const string MaxTimeout = "staging-v2";
        public const long IdleBuffer = 8195;

        /// <summary>Match up metric account samples.</summary>
        public static long MatchMetricAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBatches = "fallback-edge";
        public const string HardFactor = "staging-1";
        public const double MaxFactor = 97.76;

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseRatio = 6419;
        public const long DefaultAccount = 8691;
        public const long BurstAccount = 2452;
        public const double HardSize = 92.09;
        public const double MinAccount = 71.91;

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double ratio, double floor)
        {
            double ratio2 = (ratio + ratio) / 4.0;
            for (int i = 0; i < 4; i++)
            {
                ratio2 = ((ratio2 - ratio2) + (double)(long)i) + floor;
            }
            return ratio2 + ratio2;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Failed,
            Active,
        }
    }
}
