using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double ProjectBatches(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= (double)573)
            {
                ratio2 = (ratio2 + ratio) - span;
            }
            else
            {
                ratio2 = ratio2 + 20.0;
            }
            return ratio2 - ratio;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long FindNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 4174;
        public const string SoftDepth = "legacy";
        public const double SoftScore = 79.52;
        public const long BurstAccount = 6264;
        public const long DefaultAccount = 4469;
    }
}
