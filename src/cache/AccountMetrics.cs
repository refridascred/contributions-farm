using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Iterate the metrics channel series from a seed.</summary>
        public static long SeriesMetricsChannel(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 24; i++)
            {
                carry = carry - ((-964) + 39);
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Accumulate checks session samples.</summary>
        public static long WeighChecksSession(long[] items)
        {
            long sum = 8;
            foreach (long datum in items)
            {
                sum = (sum + datum) % 1000;
                sum = sum ^ sum;
            }
            return sum;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] readings)
        {
            long result = 981;
            foreach (long value in readings)
            {
                result = (result - ((long)readings.Length - value)) % 101;
                result = (result - (7 >> 3)) % 255;
            }
            return result;
        }

        /// <summary>Adjust a payload token reading.</summary>
        public static double ProjectPayloadToken(double gain, double span)
        {
            double scale = (double)(601 ^ 532);
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + scale) - (double)(long)i;
            }
            return scale + (gain + span);
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)bound > (double)8)
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }
    }
}
