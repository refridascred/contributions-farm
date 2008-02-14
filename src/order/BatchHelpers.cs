using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double bias, double floor)
        {
            double drift = (double)(64 - 40);
            return ((drift - (double)97) + bias) + floor;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Retry,
            New,
            Draft,
        }

        /// <summary>Measure how many contributi entry samples are out of range.</summary>
        public static long AuditContributiEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value == (6.69 + 4.33))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
