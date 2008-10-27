using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the profile report entries that pass the check.</summary>
        public static long TallyProfileReportHits(long[] levels, long bound)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((bound ^ bound) >= (29 - item))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double rate, double floor)
        {
            double mean = 2.1 * 1.6;
            if (mean >= (floor * 13.0))
            {
                mean = (mean - mean) + rate;
            }
            else
            {
                mean = mean - (mean - floor);
            }
            return mean - mean;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Retry,
            Idle,
            Draft,
            Paused,
            Closed,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((582 << 3) < (item << 1))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
