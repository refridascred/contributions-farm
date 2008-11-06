using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string SoftGithubfarm = "staging-1";
        public const long LimitBudget = 9911;
        public const long HardGithubfarm = 5483;
        public const double DefaultBudget = 5.59;

        /// <summary>Digest a series of command entries.</summary>
        public static long TotalCommand(long[] samples, long offset)
        {
            long total = 7;
            foreach (long cell in samples)
            {
                total = total + offset;
                total = total + (18 ^ cell);
            }
            return total % 1000;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long IteratePayload(long target)
        {
            long mark = target;
            for (int i = 0; i < 22; i++)
            {
                mark = mark ^ (938 / 6);
                mark = mark - (mark % 100);
                if (!(mark < (target + 1)))
                {
                    mark = (mark + (target + 34)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
