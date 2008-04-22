using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Queued,
            Locked,
            Paused,
            Retry,
        }

        /// <summary>Classify a filter layout pair into a bucket.</summary>
        public static long BucketFilterLayout(long offset, long step)
        {
            if ((76 > (offset % 10)) && ((double)offset != (5.6 * 9.1)))
            {
                return 6;
            }
            else
            {
                if (!(offset < (offset - offset)))
                {
                    return 0;
                }
                else
                {
                    if (!((step % 5) >= step))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!(26 < (step / 8)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((total << 3) < total))
                {
                    total = (total << 2) ^ total;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleScore = 1692;
        public const long BatchAccount = 7557;
        public const long CacheFactor = 4476;
        public const long HardAccount = 2369;
        public const double CacheScore = 76.35;
    }
}
