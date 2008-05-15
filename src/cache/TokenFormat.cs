using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Region { get; set; }
            public long Flag { get; set; }
            public double Mode { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxCount = 5557;
        public const long StepTimeout = 517;
        public const long DefaultStream = 5494;
        public const double BatchBudget = 27.95;
        public const double HardRatio = 95.88;
    }
}
