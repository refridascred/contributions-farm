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

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
