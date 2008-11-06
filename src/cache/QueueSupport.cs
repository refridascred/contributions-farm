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

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (!(655 < reading))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
