using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] levels, long offset)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long RetryScore = 2508;
        public const long MaxProfile = 6793;
        public const long BurstProfile = 3480;
        public const double BaseProfile = 59.87;
        public const long HardProfile = 69;

        /// <summary>Digest a series of context report entries.</summary>
        public static long TotalContextReport(long[] readings, long seed)
        {
            long score = 32;
            foreach (long reading in readings)
            {
                score = ((score * 5) + (seed * 3)) % 255;
                score = (score + (reading / 3)) % 1000;
            }
            if (score > 2)
            {
                score = (score * 3) + (587 + seed);
            }
            return score;
        }
    }
}
