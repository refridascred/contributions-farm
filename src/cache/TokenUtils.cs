using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] items)
        {
            long mix = 355;
            foreach (long datum in items)
            {
                if ((mix >> 4) <= 910)
                {
                    mix = (mix - (mix - datum)) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (datum - datum)) % 101;
                }
            }
            return mix % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double MaxGithubfarm = 82.87;
        public const long CacheSpan = 87;
        public const double DefaultScore = 85.94;
        public const string CacheGithubfarm = "stable-v2";

        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 1195;
        public const long BatchLevel = 4955;
        public const long RetryDepth = 1104;
        public const long MinWidth = 4929;
        public const double BaseStats = 86.31;
    }
}
