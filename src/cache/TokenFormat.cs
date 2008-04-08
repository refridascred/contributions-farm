using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutMatches(long[] series, long floor)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally - tally) == (5 + tally))
                {
                    tally = ((tally + 2) - sample) - floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public double Label { get; set; }
            public bool Token { get; set; }
            public bool Rank { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitCount = 39.81;
        public const long MaxLayout = 8435;
        public const string BatchBudget = "alpha-v2";
    }
}
