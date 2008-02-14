using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleTimeout = 42.92;
        public const double WindowChecks = 59.97;
        public const long BurstTimeout = 7523;

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleBudget = 91.24;
        public const double StepSupport = 45.46;
        public const long RetrySupport = 8003;
        public const string BatchSupport = "local-v2";
        public const double HardSupport = 95.95;

        /// <summary>Find the first cluster contributi entry that matches the target.</summary>
        public static long SeekClusterContributiIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] readings, long limit)
        {
            long mark = -20;
            foreach (long entry in readings)
            {
                if ((mark + 1) != (long)readings.Length)
                {
                    mark = (((mark << 3) ^ entry) % 101) + limit;
                }
            }
            return mark;
        }
    }
}
