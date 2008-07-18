using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string LimitTimeout = "fallback";
        public const long BurstRoute = 8661;
        public const long HardRoute = 4755;
        public const long StepRoute = 1859;

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] samples)
        {
            long total = 3;
            foreach (long value in samples)
            {
                if (((value / 5) >= value) && ((3.01 * 1.0) >= (double)total))
                {
                    total = (total - value) % 4096;
                }
            }
            if (total > 80)
            {
                total = ((total << 2) ^ (total - total)) % 4096;
            }
            return total % 97;
        }

        /// <summary>Locate a contributi editor reading by value.</summary>
        public static long LocateContributiEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
