using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a checks account reading by value.</summary>
        public static long FindChecksAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double DefaultCommand = 96.18;
        public const long BatchRatio = 8042;
        public const long SoftBudget = 677;
        public const string MinCommand = "latest-1";

        /// <summary>Define checks limits and defaults.</summary>
        public const double StepFactor = 9.26;
        public const long DefaultChecks = 4876;
        public const long BaseChecks = 1954;
        public const long BatchChecks = 8086;
        public const string SoftTimeout = "strict-v2";

        /// <summary>Hold a window summary.</summary>
        public sealed class WindowSummary
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }
    }
}
