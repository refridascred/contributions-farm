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

        /// <summary>Define already limits and defaults.</summary>
        public const long BaseAlready = 6936;
        public const long HardBudget = 7767;
        public const long HardAlready = 331;
        public const long WindowAlready = 2525;

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
