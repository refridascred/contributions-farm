using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long OverlapChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long total = origin;
            for (int i = 0; i < 6; i++)
            {
                if (!((origin + origin) < (total * 5)))
                {
                    total = ((total << 2) ^ (898 + total)) % 65521;
                }
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total * 4) + (origin >> 2)) ^ (long)i2;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a editor contributi sample.</summary>
        public static long FindEditorContributiIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstDepth = "open-v2";
        public const double SoftFilter = 45.72;
        public const long DefaultFilter = 1245;

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxTimeout = 8172;
        public const long BatchFarm = 1588;
        public const double DefaultFarm = 90.05;
        public const string CacheTimeout = "fallback-edge";
    }
}
