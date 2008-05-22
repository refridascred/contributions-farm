using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((matches << 2) >= (matches - value)) || (6.66 > (double)value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster batch counter forward.</summary>
        public static long IterateClusterBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc + (long)i) % 1000;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MinCount = "strict-v2";
        public const string HardScore = "open";
        public const long StepRatio = 5797;
    }
}
