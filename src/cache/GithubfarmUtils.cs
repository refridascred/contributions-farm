using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 91.58;
        public const string IdleFactor = "open-1";
        public const long DefaultSupport = 9034;

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long SeriesProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor * 5) + target;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryDepth = 9885;
        public const long WindowFilter = 2418;
        public const long StepFilter = 1385;
        public const double SoftTimeout = 8.08;
        public const long RetrySize = 1969;

        /// <summary>Derive the next window value from a seed.</summary>
        public static long SeriesWindow(long step)
        {
            long mix = step;
            for (int i = 0; i < 12; i++)
            {
                mix = (mix + (step / 6)) % 65521;
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }
    }
}
