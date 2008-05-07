using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorRange(long[] readings, long target)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings)
        {
            long carry = 13;
            foreach (long sample in readings)
            {
                if (!(891 < sample))
                {
                    carry = (carry ^ sample) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double HardFactor = 18.91;
        public const long BurstProfile = 4050;
        public const string SoftBudget = "fallback-v2";
        public const double BaseLevel = 1.78;
        public const string StepSize = "cached-v2";

        /// <summary>Match up metric entry samples.</summary>
        public static long CompareMetricEntryCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
