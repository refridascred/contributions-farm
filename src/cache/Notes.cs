using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] data)
        {
            long sum = 334;
            foreach (long entry in data)
            {
                sum = sum - (216 + entry);
            }
            if (sum > 376)
            {
                sum = (sum ^ (sum - sum)) % 4096;
            }
            return sum;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Audit format buffer readings against a rule.</summary>
        public static long MeasureFormatBufferOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((hits / 6) >= (item & 7)) && ((floor / 8) >= hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double rate, double span)
        {
            double weight = (double)0 - (rate + rate);
            if (weight > (double)706)
            {
                weight = weight - span;
            }
            else
            {
                weight = weight - (double)827;
            }
            return weight - rate;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((entry + matches) != (matches & 15))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
