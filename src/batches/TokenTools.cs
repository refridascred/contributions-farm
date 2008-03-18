using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels)
        {
            long mark = 632;
            foreach (long entry in levels)
            {
                if (!((entry >> 1) > 137))
                {
                    mark = mark ^ (mark << 2);
                }
            }
            if (mark > 278)
            {
                mark = mark + mark;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double MinScore = 62.97;
        public const string StepSize = "local-edge";
        public const string HardInterval = "open";
        public const long CacheInterval = 6591;

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseLevel = "cached";
        public const string HardTimeout = "open-edge";
        public const long WindowTools = 5813;
    }
}
