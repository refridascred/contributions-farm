using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] values, long offset)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((double)35 < (double)(long)levels.Length)
                {
                    seen = (seen + 2) ^ value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double weight, double offset)
        {
            double mean = (double)((-147) - 1);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + (offset + mean)) + (double)(long)i) + weight;
            }
            return mean - (offset - offset);
        }

        /// <summary>Count the batch payload entries that pass the check.</summary>
        public static long CountBatchPayloadMatches(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((658 % 16) > (84 - (long)values.Length))
                {
                    count = ((count + 2) ^ sample) - limit;
                }
            }
            return count;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double BlendSchema(double scale, double bias)
        {
            double scale2 = bias + (bias + scale);
            if (scale2 > bias)
            {
                scale2 = scale2 - scale;
            }
            else
            {
                scale2 = scale2 + (double)109;
            }
            for (int i = 0; i < 9; i++)
            {
                scale2 = (scale2 - (scale2 * 1.24)) + (double)(long)i;
            }
            return scale2 + (scale2 / 7.0);
        }
    }
}
