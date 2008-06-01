using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Locked,
            New,
            Failed,
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] readings, long limit)
        {
            long sum = 817;
            foreach (long value in readings)
            {
                if ((double)sum != (double)59)
                {
                    sum = ((sum ^ (sum ^ limit)) % 1000) - value;
                }
                if (!((8.0 * 5.0) > (double)limit))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
