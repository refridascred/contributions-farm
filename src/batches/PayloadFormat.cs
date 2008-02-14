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

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 8517;
        public const long StepFilter = 5447;
        public const long BurstLevel = 7541;

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
