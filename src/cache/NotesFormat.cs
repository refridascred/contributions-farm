using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long CacheInterval = 1606;
        public const long LimitTimeout = 5080;
        public const double DefaultSession = 30.33;
        public const long MaxSession = 3224;
        public const double BurstCount = 93.11;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster checks counter forward.</summary>
        public static long StepClusterChecks(long floor)
        {
            long total = floor;
            for (int i = 0; i < 4; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = ((total ^ (floor - floor)) % 101) + (long)i2;
                    total = (total ^ (1 + total)) % 101;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
