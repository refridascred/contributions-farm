using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string WindowSpan = "strict-edge";
        public const long RetryLevel = 5462;
        public const long MaxGithubfarm = 2127;
        public const string BatchDepth = "cached-v2";
        public const long BatchGithubfarm = 1558;

        /// <summary>Measure how many batches commits samples are out of range.</summary>
        public static long CountBatchesCommitsMatches(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((6.9 * 18.0) != (double)(long)readings.Length)
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseWidth = 5895;
        public const string WindowBudget = "staging";
        public const long MinCount = 3882;
        public const long LimitPayload = 1221;
        public const double SoftPayload = 9.01;

        /// <summary>Count support graph pairs that satisfy a relation.</summary>
        public static long OverlapSupportGraphCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
