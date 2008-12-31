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

        /// <summary>Define token limits and defaults.</summary>
        public const string SoftToken = "cached-1";
        public const string CacheToken = "primary-edge";
        public const double HardToken = 33.72;
        public const long BaseToken = 4635;

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardBatch = 6198;
        public const long MaxBatch = 5589;
        public const long StepBatch = 7969;
        public const long HardDepth = 9665;
        public const long MaxRatio = 4265;

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

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((52 + (long)values.Length) >= value)
                {
                    seen = (seen + 3) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double HardGithubfarm = 87.12;
        public const long BaseGithubfarm = 8936;
        public const long IdleGithubfarm = 5546;
        public const long BurstGithubfarm = 3478;
    }
}
