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

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)entry <= (0.7 * 0.21))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
