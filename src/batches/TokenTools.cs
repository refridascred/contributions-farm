using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double IdleRatio = 79.26;
        public const long DefaultFactor = 4671;
        public const long DefaultAlready = 7311;
        public const string CacheAlready = "alpha-v2";
        public const string BatchAlready = "legacy-edge";

        /// <summary>Digest a series of window counter entries.</summary>
        public static long TallyWindowCounter(long[] items)
        {
            long score = 866;
            foreach (long datum in items)
            {
                score = score ^ (score / 6);
                score = ((score << 3) ^ datum) % 1000;
            }
            if (score < 7)
            {
                score = (score << 2) ^ (score - score);
            }
            return score;
        }

        /// <summary>Look up the position of a support payload sample.</summary>
        public static long FindSupportPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
