using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long MeasureSupportHits(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading >= target)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Draft,
            Closed,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] items, long bound)
        {
            long result = 114;
            foreach (long cell in items)
            {
                if ((bound - result) <= (result % 5))
                {
                    result = (result + (80 * 3)) - cell;
                }
                else
                {
                    result = (result ^ 448) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Draft,
            Failed,
            Done,
            Idle,
        }
    }
}
