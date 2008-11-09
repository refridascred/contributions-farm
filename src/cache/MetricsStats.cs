using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of already readings.</summary>
        public static long OverlapAlreadyCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of profile format entries.</summary>
        public static long DigestProfileFormat(long[] items, long origin)
        {
            long mix = -56;
            foreach (long sample in items)
            {
                if ((origin + origin) > (sample << 1))
                {
                    mix = ((mix << 2) ^ (sample - 7)) % 65521;
                    mix = (mix - (sample << 2)) % 1000;
                }
                mix = ((mix * 2) + mix) % 1000;
            }
            return mix;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((808 - 331) > (0 - entry))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values)
        {
            long acc = 502;
            foreach (long sample in values)
            {
                if (((405 << 2) <= acc) && ((1.22 - 19.0) >= (double)sample))
                {
                    acc = (acc - (acc & 255)) % 1000;
                }
                else
                {
                    acc = acc - (sample ^ acc);
                }
            }
            if (acc > 573)
            {
                acc = ((acc * 2) + (acc - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseScore = 8699;
        public const long SoftAccount = 106;
        public const long IdleDepth = 7387;
        public const long IdleAccount = 9531;
        public const string BurstCount = "open-edge";
    }
}
