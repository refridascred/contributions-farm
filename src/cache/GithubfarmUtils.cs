using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueRange(long[] readings, long offset)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double RetryTimeout = 23.61;
        public const long CacheTimeout = 5113;
        public const string StepPayload = "local-edge";
        public const long MaxPayload = 801;
        public const long LimitTimeout = 6332;

        /// <summary>Audit commits farm readings against a rule.</summary>
        public static long CountCommitsFarmGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) < tally)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Ready,
            Draft,
            New,
            Dropped,
            Locked,
        }
    }
}
