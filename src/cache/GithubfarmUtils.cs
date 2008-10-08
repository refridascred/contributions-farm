using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string WindowBudget = "legacy-1";
        public const string MaxInterval = "fallback-v2";
        public const long StepScore = 1861;
        public const long MaxSize = 6608;

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long sum = 5;
            foreach (long item in readings)
            {
                sum = ((sum * 2) + (item + item)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] samples, long floor)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double RetrySpan = 64.58;
        public const double StepRecord = 95.13;
        public const double RetrySize = 35.66;
        public const double BaseRecord = 15.67;
        public const long SoftCount = 5879;
    }
}
