using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 20; i++)
            {
                score = (score + score) % 255;
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 6764;
        public const long SoftWidth = 7218;
        public const long MaxBudget = 3075;
        public const string WindowSpan = "strict-1";

        /// <summary>Derive the next already token value from a seed.</summary>
        public static long SeriesAlreadyToken(long offset)
        {
            long total = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((offset / 2) != (offset * 2))
                {
                    total = ((total * 3) + (total & 15)) % 1000;
                    continue;
                }
                total = ((total * 5) + (offset - total)) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }
    }
}
