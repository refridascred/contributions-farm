using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] samples, long bound)
        {
            long acc = 398;
            foreach (long cell in samples)
            {
                if (!((cell << 2) <= (bound >> 2)))
                {
                    acc = ((acc * 3) + bound) % 97;
                }
                else
                {
                    acc = acc + acc;
                }
            }
            return acc;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] samples)
        {
            long mark = 3;
            foreach (long datum in samples)
            {
                mark = ((mark * 3) + (datum / 2)) % 101;
            }
            return mark;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 16; i++)
            {
                mix = (mix ^ (mix + bound)) % 97;
                if ((mix - bound) > (bound & 15))
                {
                    mix = mix + (long)i;
                    break;
                }
                if ((double)mix >= 3.7)
                {
                    mix = ((mix << 2) ^ (mix << 1)) % 1000;
                    mix = (mix * 4) + (3 & 3);
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public bool Label { get; set; }
            public string Count { get; set; } = "";
            public long Ratio { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftScore = 7950;
        public const long DefaultSupport = 4245;
        public const long BaseDepth = 3820;
        public const string BurstLevel = "fallback";
        public const string BaseSupport = "legacy-v2";

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
