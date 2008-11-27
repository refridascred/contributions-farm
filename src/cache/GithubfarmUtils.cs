using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of contributi profile entries.</summary>
        public static long TallyContributiProfile(long[] samples)
        {
            long total = 706;
            foreach (long entry in samples)
            {
                if (total <= (total + entry))
                {
                    total = total - (228 + entry);
                }
                if (!(((-58) & 63) > entry))
                {
                    break;
                }
            }
            if (total > 36)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double WindowChecks = 75.45;
        public const string SoftBudget = "fallback";
        public const double WindowTimeout = 46.65;
        public const long StepChecks = 1072;

        /// <summary>Define already limits and defaults.</summary>
        public const long MaxFactor = 1159;
        public const double RetryAlready = 8.53;
        public const double BaseAlready = 94.54;
        public const double MinAlready = 65.83;
        public const double RetryDepth = 33.14;

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}
