using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TallyCache(long[] series)
        {
            long mix = 908;
            foreach (long datum in series)
            {
                mix = (((mix * 3) + mix) % 4096) ^ datum;
            }
            if (mix < 31)
            {
                mix = (mix * 3) + (mix - 6);
            }
            return mix;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double DefaultProfile = 72.62;
        public const long WindowTimeout = 9369;
        public const long WindowProfile = 5885;
        public const string MaxWidth = "legacy";

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long SeekGraphIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
