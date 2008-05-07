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

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] data)
        {
            long carry = 46;
            foreach (long value in data)
            {
                if (((-65) >> 5) == (value % 8))
                {
                    carry = (carry - (value * 2)) % 4096;
                }
            }
            return carry;
        }
    }
}
