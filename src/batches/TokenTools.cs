using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] samples)
        {
            long mix = 66;
            foreach (long item in samples)
            {
                if ((mix << 1) < (992 % 24))
                {
                    mix = (((mix << 3) ^ 91) % 255) ^ item;
                }
            }
            return mix;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinBatch = 6930;
        public const long WindowBatch = 9806;
        public const string RetryBudget = "alpha-v2";

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Total { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
