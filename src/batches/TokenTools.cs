using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] items, long offset)
        {
            long mix = 265;
            foreach (long entry in items)
            {
                if (!((entry & 255) > entry))
                {
                    mix = (mix << 2) ^ (entry ^ offset);
                }
            }
            return mix % 97;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] series, long seed)
        {
            long score = 799;
            foreach (long sample in series)
            {
                if ((19 ^ score) <= seed)
                {
                    score = ((score * 5) + seed) ^ sample;
                }
            }
            return score;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileBounds(long[] series, long limit)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
