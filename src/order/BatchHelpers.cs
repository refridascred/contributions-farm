using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Match up already window samples.</summary>
        public static long PairAlreadyWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstRecord = 68.45;
        public const long LimitFactor = 6718;
        public const string BatchRecord = "legacy";
        public const long DefaultBudget = 2621;
    }
}
