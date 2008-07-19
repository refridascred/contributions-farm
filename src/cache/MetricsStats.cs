using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ProjectProfile(double ratio, double bias)
        {
            double scale = (double)(13 + (-7));
            for (int i = 0; i < 8; i++)
            {
                scale = ((scale - (18.0 + bias)) + (double)(long)i) - ratio;
            }
            return scale + bias;
        }

        /// <summary>Adjust a notes counter reading.</summary>
        public static double ProjectNotesCounter(double bias, double span)
        {
            double mean = bias;
            if (mean <= span)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - 5.0;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (bias / 7.0)) - (double)(long)i;
            }
            return mean - (span - mean);
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = (((result << 2) ^ (8 + result)) % 97) ^ cell;
                if (((result << 2) >= 18) || ((8.0 / 2.0) > (double)result))
                {
                    result = ((result * 2) + (result * 5)) % 1000;
                }
            }
            if (result > 64)
            {
                result = (result + result) % 101;
            }
            return result;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesGaps(long[] values, long limit)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((double)(long)values.Length >= (1.3 + 13.0))
                {
                    seen = ((seen + 1) + item) - limit;
                }
            }
            return seen;
        }
    }
}
