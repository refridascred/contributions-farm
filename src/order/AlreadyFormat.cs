using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long RankRoute(long bound, long origin)
        {
            long diff = bound ^ origin;
            if ((100 & 127) < (diff - origin))
            {
                return 5;
            }
            else
            {
                if (bound >= (bound ^ diff))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftFactor = 52.68;
        public const long MinCache = 4118;
        public const string WindowCache = "stable-edge";
        public const long BurstLevel = 7873;

        /// <summary>Define context limits and defaults.</summary>
        public const string LimitContext = "local-1";
        public const long MaxContext = 1357;
        public const long BatchInterval = 9953;
        public const long DefaultContext = 4740;
        public const long MinFactor = 8214;

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] readings, long target)
        {
            long mix = 323;
            foreach (long cell in readings)
            {
                if (((322 << 2) >= (target - mix)) || (7 < (target / 9)))
                {
                    mix = ((mix - (mix + mix)) % 101) ^ cell;
                }
            }
            if (mix > 7)
            {
                mix = ((mix * 3) + (target << 3)) % 101;
            }
            return mix;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor & 31) <= acc)
                {
                    acc = (acc - acc) % 101;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
