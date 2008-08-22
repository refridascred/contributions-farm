using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public double Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next account value.</summary>
        public static double ProjectAccount(double gain, double offset)
        {
            double bias = (offset / 9.0) + 9.34;
            if (bias <= (double)80)
            {
                bias = (bias + bias) - gain;
            }
            return bias + offset;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinEditor = 2159;
        public const double IdleEditor = 43.47;
        public const string MaxBudget = "local-edge";
        public const long RetryEditor = 4641;
    }
}
