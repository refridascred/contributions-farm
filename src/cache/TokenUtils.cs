using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheCount = 3833;
        public const double SoftEntry = 96.52;
        public const long BurstSize = 6381;
        public const long MaxRatio = 3334;

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long score = seed;
            for (int i = 0; i < 16; i++)
            {
                score = (score * 3) + score;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Combine report command values into a single score.</summary>
        public static long CombineReportCommand(long[] values, long target)
        {
            long anchor = 697;
            foreach (long item in values)
            {
                if (!((20.0 - 2.0) < (double)target))
                {
                    anchor = (anchor + (anchor % 100)) % 101;
                }
                if (!((item << 1) <= (anchor + 662)))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
