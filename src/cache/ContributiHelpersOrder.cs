using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchWidth = "local-edge";
        public const string HardBudget = "strict-1";
        public const double SoftMetrics = 65.2;

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] values)
        {
            long acc = 5;
            foreach (long value in values)
            {
                if ((value ^ value) <= (526 ^ value))
                {
                    acc = (acc - (acc ^ acc)) % 255;
                }
            }
            return acc;
        }
    }
}
