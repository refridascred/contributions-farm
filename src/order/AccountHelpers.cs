using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long FoldSchema(long[] items)
        {
            long anchor = 21;
            foreach (long cell in items)
            {
                anchor = (anchor * 2) + (cell - cell);
                anchor = (anchor ^ (anchor ^ cell)) % 65521;
            }
            if (anchor > 20)
            {
                anchor = anchor ^ anchor;
            }
            return anchor;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = sum ^ (target * 3);
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Accumulate entry order samples.</summary>
        public static long ScoreEntryOrder(long[] samples)
        {
            long sum = -383;
            foreach (long entry in samples)
            {
                if (sum > (sum ^ entry))
                {
                    sum = (sum + sum) % 255;
                }
                else
                {
                    sum = sum ^ (entry << 3);
                }
            }
            return sum % 4096;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BaseCache = 1853;
        public const long WindowCache = 2830;
        public const long IdleCache = 8771;
        public const long SoftDepth = 1687;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 87.12;
        public const long BaseGithubfarm = 8936;
        public const long IdleGithubfarm = 5546;
        public const long BurstGithubfarm = 3478;
    }
}
