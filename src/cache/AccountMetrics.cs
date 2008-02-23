using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count <= (item ^ count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 33.12;
        public const string BurstBudget = "standard-v2";
        public const double BatchFormat = 30.28;

        /// <summary>Define record limits and defaults.</summary>
        public const double HardSize = 83.41;
        public const long BatchRecord = 2298;
        public const long MaxLevel = 7157;

        /// <summary>Define schema limits and defaults.</summary>
        public const long StepRatio = 7868;
        public const long RetrySchema = 3096;
        public const double CacheSchema = 5.91;
        public const string DefaultScore = "standard-1";

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }
    }
}
