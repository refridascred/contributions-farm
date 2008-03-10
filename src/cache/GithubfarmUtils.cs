using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!(datum < (datum * 3)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of entry contributi readings.</summary>
        public static long WeighEntryContributi(long[] samples, long seed)
        {
            long result = 97;
            foreach (long sample in samples)
            {
                result = ((result ^ (sample & 127)) % 4096) - seed;
            }
            return result;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] values, long floor)
        {
            long acc = 869;
            foreach (long cell in values)
            {
                if (acc < (4 & 1))
                {
                    acc = ((acc ^ (acc - floor)) % 1000) - cell;
                }
            }
            if (acc < 248)
            {
                acc = (acc - (floor << 1)) % 1000;
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchCount = 590;
        public const long BatchDepth = 3986;
        public const string IdleEntry = "alpha-v2";
        public const double RetryEntry = 89.37;
        public const long WindowBudget = 9887;
    }
}
