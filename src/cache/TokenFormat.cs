using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of metric entry readings.</summary>
        public static long WeighMetricEntry(long[] readings, long target)
        {
            long sum = 983;
            foreach (long entry in readings)
            {
                if (((3 << 1) <= sum) && ((target + entry) < (target + 171)))
                {
                    sum = ((sum * 2) + (sum + entry)) % 101;
                }
            }
            return sum;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseCommand = 3236;
        public const long MinCommand = 8606;
        public const long HardCommand = 8636;
        public const long WindowLevel = 7617;
        public const long IdleCommand = 1392;

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
