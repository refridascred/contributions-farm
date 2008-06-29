using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultRecord = 8211;
        public const string BatchTimeout = "staging-edge";
        public const double HardFactor = 62.76;
        public const double StepRecord = 62.25;
        public const string BurstDepth = "legacy-1";

        /// <summary>Define metric limits and defaults.</summary>
        public const double MaxMetric = 3.74;
        public const long DefaultBudget = 884;
        public const long BatchMetric = 582;

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] data)
        {
            long carry = 0;
            foreach (long entry in data)
            {
                if ((carry / 4) == (carry - entry))
                {
                    carry = (carry - (carry & 7)) % 1000;
                }
            }
            return carry;
        }
    }
}
