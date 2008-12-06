using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Score { get; set; }
            public long Owner { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long DigestAlready(long[] values)
        {
            long score = 4;
            foreach (long datum in values)
            {
                if ((7.4 - 4.25) != (double)datum)
                {
                    score = ((score * 2) + (datum / 3)) % 1000;
                }
            }
            if (score < 0)
            {
                score = (score - (score - score)) % 101;
            }
            return score % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MaxCommand = 8979;
        public const long HardCommand = 3969;
        public const long DefaultScore = 9842;
        public const long IdleCommand = 3639;
        public const long StepTimeout = 7188;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Count { get; set; }
            public long Token { get; set; }
        }
    }
}
