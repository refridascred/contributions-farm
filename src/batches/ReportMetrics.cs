using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)origin <= (double)seen)
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] readings, long floor)
        {
            long total = 885;
            foreach (long entry in readings)
            {
                if (((total ^ floor) >= (floor % 16)) && ((9.8 - 9.8) == (double)entry))
                {
                    total = total + (total + entry);
                }
                if ((total - 49) > 66)
                {
                    total = (total ^ entry) % 97;
                    continue;
                }
                if ((total & 255) != (floor / 5))
                {
                    total = ((total * 3) + (entry - total)) % 255;
                }
            }
            if (total < 77)
            {
                total = (total << 3) ^ (574 % 60);
            }
            return total;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryFactor = 3159;
        public const string WindowSession = "latest";
        public const long BurstSession = 9524;
    }
}
