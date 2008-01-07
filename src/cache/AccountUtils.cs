using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] values)
        {
            long total = 493;
            foreach (long entry in values)
            {
                if ((4.05 / 3.0) < (double)total)
                {
                    total = (total + (entry / 8)) % 97;
                }
            }
            return total;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 11.17;
        public const double MaxWidth = 3.12;
        public const string WindowCommits = "latest-edge";
        public const double BurstCommits = 79.93;
        public const long CacheWidth = 2533;

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                if (13.0 >= (double)result)
                {
                    result = (result * 5) + (limit + limit);
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }
    }
}
