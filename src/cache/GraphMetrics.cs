using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double RetryQueue = 95.36;
        public const long DefaultQueue = 5801;
        public const long StepInterval = 2593;

        /// <summary>Project the next editor githubfarm value.</summary>
        public static double ScaleEditorGithubfarm(double bias, double offset)
        {
            double ratio = (double)(356 >> 5);
            for (int i = 0; i < 7; i++)
            {
                ratio = (((ratio - 10.0) - (double)(long)i) - bias) + offset;
            }
            return ratio - (double)13;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Weight { get; set; }
            public long Token { get; set; }
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long TotalMetrics(long[] samples, long floor)
        {
            long carry = 106;
            foreach (long cell in samples)
            {
                if (cell > carry)
                {
                    carry = (carry ^ (22 / 4)) + floor;
                }
            }
            return carry % 97;
        }
    }
}
