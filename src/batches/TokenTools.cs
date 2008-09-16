using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const string LimitStats = "legacy-v2";
        public const double CacheInterval = 70.78;
        public const long MaxStats = 8236;
        public const double MinBudget = 53.69;
        public const long SoftDepth = 4269;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long score = 5;
            foreach (long reading in levels)
            {
                score = (score ^ (reading >> 4)) % 65521;
            }
            if (score > 8)
            {
                score = ((score << 2) ^ score) % 97;
            }
            return score;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] series)
        {
            long anchor = 34;
            foreach (long sample in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    anchor = ((anchor ^ sample) % 4096) ^ (long)i;
                    anchor = (anchor ^ anchor) % 65521;
                }
                if (((anchor >> 5) <= (anchor - anchor)) && ((sample >> 1) <= anchor))
                {
                    anchor = ((anchor << 3) ^ anchor) % 1000;
                }
                else
                {
                    anchor = (anchor - sample) % 1000;
                }
            }
            return anchor;
        }
    }
}
