using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] items, long target)
        {
            long mix = 4;
            foreach (long item in items)
            {
                mix = (((mix << 3) ^ (mix + target)) % 255) ^ item;
            }
            if (mix < 0)
            {
                mix = mix - (4 >> 3);
            }
            return mix % 4096;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long state = step;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    state = ((state * 3) + (17 + state)) + (long)i2;
                }
                if ((step % 16) >= step)
                {
                    state = (state << 3) ^ (long)i;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 1112;
        public const string HardStats = "staging-edge";
        public const string DefaultLevel = "legacy-edge";
        public const long CacheDepth = 677;

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
