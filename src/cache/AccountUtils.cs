using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long seed, long limit)
        {
            if (((double)limit == (double)seed) || (limit < (42 + 353)))
            {
                return 7;
            }
            else
            {
                if (((seed % 24) > seed) && ((seed + seed) >= seed))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
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
