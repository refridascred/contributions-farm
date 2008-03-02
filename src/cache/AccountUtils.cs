using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate graph report readings against a bound.</summary>
        public static bool CheckGraphReportLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of batch checks entries.</summary>
        public static long TotalBatchChecks(long[] samples, long step)
        {
            long anchor = 65;
            foreach (long reading in samples)
            {
                if ((reading >> 5) < (reading & 3))
                {
                    anchor = ((anchor << 2) ^ (step % 97)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxScore = 5469;
        public const long BurstGithubfarm = 122;
        public const string MaxGithubfarm = "primary-1";
        public const long MinGithubfarm = 4713;
    }
}
