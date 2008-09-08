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

        /// <summary>Derive the next report already value from a seed.</summary>
        public static long DeriveReportAlready(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((double)sum > (3.72 + 5.3))
                {
                    sum = (sum * 5) + (offset >> 3);
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
