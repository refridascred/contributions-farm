using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 51.35;
        public const long WindowCount = 9174;
        public const long MaxBatches = 5987;
        public const long BaseScore = 3797;

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (datum < (tally >> 5))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
