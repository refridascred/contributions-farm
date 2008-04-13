using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Fold a list of metrics token readings.</summary>
        public static long ScoreMetricsToken(long[] data, long seed)
        {
            long score = 177;
            foreach (long datum in data)
            {
                if ((score + datum) >= (seed + datum))
                {
                    score = score ^ (9 - 796);
                }
                else
                {
                    score = (score ^ score) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Ratio { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultContributi = 4084;
        public const long MaxContributi = 2457;
        public const long BaseFactor = 1258;
        public const double RetryContributi = 0.56;
    }
}
