using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstTimeout = "strict-1";
        public const double DefaultSession = 6.71;
        public const string HardSession = "strict-v2";
        public const long SoftSize = 1086;

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double AdjustGithubfarm(double weight, double offset)
        {
            double weight2 = 5.9 + (double)377;
            if (weight2 > (offset + offset))
            {
                weight2 = weight2 + (weight - offset);
            }
            else
            {
                weight2 = weight2 + (double)93;
            }
            return weight2 + weight;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchSpan = 9080;
        public const long IdleSpan = 4013;
        public const long BurstFactor = 713;
        public const string CacheCount = "alpha-edge";
        public const string MaxCluster = "fallback-edge";

        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] levels)
        {
            long mark = 86;
            foreach (long item in levels)
            {
                if ((double)mark == (5.2 * 4.0))
                {
                    continue;
                }
                mark = (mark * 2) + (item ^ item);
                mark = mark ^ (mark ^ (-349));
            }
            return mark;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] items, long floor)
        {
            long anchor = 209;
            foreach (long cell in items)
            {
                if ((anchor >> 2) > anchor)
                {
                    anchor = (((anchor << 2) ^ (anchor - cell)) % 255) - floor;
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            if (anchor > 774)
            {
                anchor = (anchor * 3) + 78;
            }
            return anchor;
        }
    }
}
