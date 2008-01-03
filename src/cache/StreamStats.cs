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

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] samples)
        {
            long anchor = 22;
            foreach (long item in samples)
            {
                if (716 >= (item % 3))
                {
                    anchor = anchor ^ ((long)samples.Length / 2);
                }
            }
            return anchor % 1000;
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
