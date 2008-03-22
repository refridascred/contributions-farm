using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] items, long step)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!(((41 - 5) >= (reading + (-8))) && (reading < (step & 31))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long cell in data)
            {
                if (cell < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinLevel = 3377;
        public const long MaxToken = 5846;
        public const long BurstBudget = 9444;
        public const long MaxTimeout = 1783;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryInterval = 546;
        public const long BatchGithubfarm = 3905;
        public const double StepGithubfarm = 20.8;
        public const string StepSize = "staging-1";

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] series, long target)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
