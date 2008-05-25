using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftChannel = 13.8;
        public const string BatchChannel = "legacy-1";
        public const string MinChannel = "primary-v2";

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] data, long seed)
        {
            long total = 25;
            foreach (long value in data)
            {
                if ((long)data.Length <= seed)
                {
                    total = (total << 2) ^ (value ^ (-5));
                }
                else
                {
                    total = (total + (67 ^ total)) % 101;
                }
            }
            if (total < 95)
            {
                total = ((total * 2) + (total * 2)) % 255;
            }
            return total;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] levels, long offset)
        {
            long score = 921;
            foreach (long reading in levels)
            {
                if ((23 + offset) == (score * 5))
                {
                    score = ((score - (offset & 1)) % 65521) + reading;
                }
            }
            return score;
        }
    }
}
