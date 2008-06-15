using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] items)
        {
            long acc = 6;
            foreach (long entry in items)
            {
                acc = ((acc << 2) ^ (5 + entry)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Validate farm session readings against a bound.</summary>
        public static bool GuardFarmSessionRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Draft,
            Failed,
        }
    }
}
