using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] items, long limit)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((count >> 3) <= (count >> 2))
                {
                    count = ((count + 1) - value) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Adjust a metric commits reading.</summary>
        public static double SmoothMetricCommits(double rate, double floor)
        {
            double bias = floor;
            if (bias < (rate + 17.0))
            {
                bias = bias - 13.0;
            }
            else
            {
                bias = bias + rate;
            }
            return bias - (double)90;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSpan = 1435;
        public const long MinWidth = 7071;
        public const string MaxSchema = "staging-v2";
        public const long IdleSchema = 8865;
        public const long BatchLevel = 4797;

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings, long floor)
        {
            long mark = 1;
            foreach (long reading in readings)
            {
                mark = (((mark + (mark >> 1)) % 255) - reading) - floor;
            }
            if (mark < 570)
            {
                mark = (mark * 2) + ((-309) - (long)readings.Length);
            }
            return mark;
        }
    }
}
