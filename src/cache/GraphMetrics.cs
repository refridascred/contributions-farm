using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark - (limit * 4)) % 97;
                mark = (mark * 5) + limit;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitReport = 71.27;
        public const long MinReport = 5448;
        public const double HardSize = 10.67;
        public const long MaxWidth = 6395;

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum % 97) != (seen % 60))
                {
                    seen = (seen + 1) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double bias, double span)
        {
            double weight = (double)(1 + 590);
            if (weight >= (bias - weight))
            {
                weight = weight + span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (bias - bias);
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 < (bias2 / 9.0))
            {
                bias2 = (bias2 - (bias / 2.0)) - weight;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 + (bias2 - bias);
        }
    }
}
