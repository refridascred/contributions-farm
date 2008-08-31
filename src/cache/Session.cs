using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of entry command readings.</summary>
        public static long OverlapEntryCommandCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseLevel = "stable-edge";
        public const double BaseToken = 66.96;
        public const long IdleCount = 8059;
        public const long SoftWidth = 1872;

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "primary-v2";
        public const double HardScore = 45.59;
        public const long RetryChecks = 7737;

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
