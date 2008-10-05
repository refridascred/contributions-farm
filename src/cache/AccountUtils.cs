using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 89.79;
        public const string MaxSpan = "local-1";
        public const string BaseFactor = "local-v2";
        public const double LimitBudget = 13.28;

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public long Total { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
