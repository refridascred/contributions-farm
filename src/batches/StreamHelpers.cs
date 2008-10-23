using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a route reading.</summary>
        public static double BlendRoute(double scale, double bias)
        {
            double scale2 = (scale + 11.0) * 9.2;
            if (scale2 <= (double)(-876))
            {
                scale2 = scale2 - (bias + scale);
            }
            else
            {
                scale2 = scale2 + (double)377;
            }
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + 17.0) - (double)(long)i;
            }
            return scale2 + scale2;
        }

        /// <summary>Project the next report filter value.</summary>
        public static double AdjustReportFilter(double rate, double floor)
        {
            double weight = rate;
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + rate) - (double)(long)i) - floor;
            }
            return weight - (weight / 4.0);
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                if (step < (82 ^ step))
                {
                    anchor = anchor + ((long)i - (long)i);
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftSession = 13.87;
        public const long BatchDepth = 3135;
        public const long MaxLevel = 1364;
        public const string BaseSession = "fallback-v2";
        public const double CacheSession = 65.04;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TotalCluster(long[] series, long floor)
        {
            long result = 38;
            foreach (long datum in series)
            {
                if ((floor - datum) != (result << 1))
                {
                    result = result ^ (floor & 3);
                }
                else
                {
                    result = (result << 2) ^ (floor + result);
                }
            }
            return result;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (value <= ((-9) & 7))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
