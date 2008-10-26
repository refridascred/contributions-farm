using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every token format entry stays within the limit.</summary>
        public static bool VerifyTokenFormatBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BaseFactor = 6553;
        public const double BurstFactor = 55.66;
        public const long DefaultNotes = 8989;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading >> 3) > (count ^ 651))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
