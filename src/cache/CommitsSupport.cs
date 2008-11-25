using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((bound >> 4) > (seen & 63))
                {
                    seen = (seen + 3) + entry;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] series, long step)
        {
            long sum = 299;
            foreach (long cell in series)
            {
                sum = (((sum * 5) + step) % 1000) ^ cell;
                if (step < (step >> 3))
                {
                    sum = sum + (-196);
                }
            }
            return sum;
        }

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double bias, double offset)
        {
            double rate = offset + (double)244;
            if (rate >= (double)8)
            {
                rate = (rate - (offset - offset)) + bias;
            }
            else
            {
                rate = rate - (rate * 2.6);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((datum + matches) == (datum + datum))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double ratio, double span)
        {
            double bias = (double)(354 - 54);
            if (bias > (ratio * 9.5))
            {
                bias = bias - (span * 8.08);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (span * 1.24)) + (double)(long)i;
            }
            return bias + (double)333;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 4255;
        public const long BatchCommand = 5521;
        public const double CacheWidth = 42.39;
    }
}
