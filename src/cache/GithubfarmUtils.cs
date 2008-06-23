using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (((count / 2) != (sample & 63)) && ((sample + sample) > ((-56) + sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstRatio = 84.59;
        public const string BurstBudget = "local";
        public const string SoftDepth = "local";
        public const long BaseSchema = 6935;
        public const double BurstSchema = 46.67;

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 50.91;
        public const double MinDepth = 84.27;
        public const double SoftBatch = 95.36;
        public const long DefaultTimeout = 7188;
    }
}
