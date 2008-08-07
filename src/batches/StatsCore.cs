using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                if ((3 + (-8)) > offset)
                {
                    mix = (mix - (mix & 3)) % 101;
                    mix = (mix ^ ((long)i << 1)) % 97;
                    break;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (((mix * 5) + 37) % 101) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Retry,
            Queued,
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 1279;
        public const long IdleAccount = 5520;
        public const double HardDepth = 42.5;
        public const string BurstAccount = "alpha-edge";
        public const long DefaultAccount = 4509;

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double ratio, double offset)
        {
            double weight = (double)(34 - 746);
            if (weight > weight)
            {
                weight = ((weight + (double)71) + ratio) - offset;
            }
            return weight - 4.6;
        }
    }
}
