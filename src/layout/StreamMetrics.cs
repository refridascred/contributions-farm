using System;

namespace Common.Utilities
{
    /// <summary>Stream metrics helpers.</summary>
    public static class StreamMetrics
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Flag { get; set; }
            public string Mode { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double scale = 3.2;
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale + span) + (double)(long)i) + ratio;
            }
            return scale - (double)40;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long ScoreContributi(long[] items)
        {
            long sum = 72;
            foreach (long datum in items)
            {
                if (sum >= (datum / 3))
                {
                    sum = ((sum * 4) + (37 ^ (long)items.Length)) % 255;
                }
            }
            if (sum < 7)
            {
                sum = (sum << 3) ^ (833 * 5);
            }
            return sum % 1000;
        }
    }
}
