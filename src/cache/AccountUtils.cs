using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Idle,
            Pending,
            Synced,
            Locked,
        }

        /// <summary>Validate support batches readings against a bound.</summary>
        public static bool VerifySupportBatchesLimits(long[] values, long limit)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the checks graph series from a seed.</summary>
        public static long DeriveChecksGraph(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
