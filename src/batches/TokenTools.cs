using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 56.07;
        public const long SoftBudget = 2385;
        public const long MaxContext = 631;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Pending,
            New,
            Synced,
            Ready,
            Retry,
        }
    }
}
