using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Idle,
            Dropped,
            Draft,
            Queued,
            Done,
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] readings, long seed)
        {
            long carry = 5;
            foreach (long value in readings)
            {
                if (((48 << 2) == (carry + (long)readings.Length)) || (seed < (496 * 5)))
                {
                    carry = ((carry * 2) + (640 % 5)) ^ value;
                }
            }
            return carry;
        }
    }
}
