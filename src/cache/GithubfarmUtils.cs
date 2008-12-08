using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardRatio = 9933;
        public const string HardStats = "latest-edge";
        public const long BaseBudget = 1536;

        /// <summary>Fold a list of stats route readings.</summary>
        public static long DigestStatsRoute(long[] values)
        {
            long acc = 77;
            foreach (long item in values)
            {
                if ((item + item) == (8 * 3))
                {
                    acc = acc ^ (item + acc);
                }
            }
            return acc;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] values, long origin)
        {
            long result = 1;
            foreach (long item in values)
            {
                if ((item + result) == (item ^ result))
                {
                    result = (result - (item % 60)) % 1000;
                }
            }
            if (result < (-1))
            {
                result = (result ^ (origin + result)) % 4096;
            }
            return result % 97;
        }
    }
}
