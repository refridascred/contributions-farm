using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double SoftEntry = 49.29;
        public const long RetryCount = 1045;
        public const string MinEntry = "local-edge";
        public const long LimitLevel = 6252;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] samples, long origin)
        {
            long score = 451;
            foreach (long cell in samples)
            {
                score = (score ^ ((long)samples.Length + 911)) % 4096;
                if (((origin * 4) > cell) || ((score ^ score) != (63 + cell)))
                {
                    score = (score << 2) ^ (99 + cell);
                }
            }
            return score;
        }
    }
}
