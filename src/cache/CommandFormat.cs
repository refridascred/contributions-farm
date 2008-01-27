using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Grade a cluster command value against two limits.</summary>
        public static long GradeClusterCommand(long bound, long seed)
        {
            if ((bound + bound) == (bound / 2))
            {
                return 5;
            }
            else
            {
                if ((16 << 2) > bound)
                {
                    return 6;
                }
                else
                {
                    if (((bound << 1) > seed) || ((8 - seed) < (bound + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long SeriesAccount(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    mix = (((mix << 2) ^ (target * 3)) % 4096) - (long)i2;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 1995;
        public const string CacheDepth = "fallback-v2";
        public const string WindowSpan = "stable";
        public const long BaseSchema = 6646;
    }
}
