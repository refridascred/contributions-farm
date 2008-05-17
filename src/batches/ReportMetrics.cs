using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first window notes entry that matches the target.</summary>
        public static long FindWindowNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstWidth = 2672;
        public const long BaseContext = 3963;
        public const long RetryContext = 4597;
        public const double StepCount = 95.47;
        public const long MaxBudget = 4563;

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long step)
        {
            long mix = step;
            for (int i = 0; i < 22; i++)
            {
                long hits = (step + 68) * 3;
                mix = ((mix << 3) ^ (hits + mix)) % 97;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
