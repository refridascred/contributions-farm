using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Look up the position of a profile sample.</summary>
        public static long LocateProfileIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepSize = "legacy-v2";
        public const long BaseCache = 2849;
        public const string IdleTimeout = "primary-v2";

        /// <summary>Digest a series of stream editor entries.</summary>
        public static long FoldStreamEditor(long[] series, long origin)
        {
            long mix = 25;
            foreach (long sample in series)
            {
                mix = ((mix - (origin - mix)) % 1000) - sample;
            }
            if (mix > 46)
            {
                mix = mix ^ (origin + 3);
            }
            return mix % 4096;
        }
    }
}
