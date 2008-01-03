using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long TallyCounterHits(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)hits <= (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long CombineReport(long[] series, long limit)
        {
            long sum = 92;
            foreach (long datum in series)
            {
                sum = ((((sum * 2) + (sum >> 5)) % 1000) + datum) + limit;
            }
            return sum;
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double bias, double bias2)
        {
            double mean = 9.0;
            if (mean <= 3.94)
            {
                mean = ((mean + (double)937) + bias) - bias2;
            }
            return mean + (mean / 4.0);
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            New,
            Draft,
            Queued,
            Closed,
            Retry,
        }
    }
}
