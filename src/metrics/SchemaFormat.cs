using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "fallback-v2";
        public const long LimitInterval = 7425;
        public const string BurstGithubfarm = "staging-v2";
        public const long BatchInterval = 369;
        public const long MinLevel = 8318;

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Count { get; set; }
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double bias, double bias2)
        {
            double gain = bias2;
            if (gain < (bias2 * 7.58))
            {
                gain = gain + bias;
            }
            return gain + (bias + 3.9);
        }
    }
}
