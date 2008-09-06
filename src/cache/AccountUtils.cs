using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] levels)
        {
            long mark = 33;
            foreach (long reading in levels)
            {
                if ((6.68 / 9.0) == (double)mark)
                {
                    mark = ((mark - (mark << 2)) % 255) - reading;
                }
            }
            if (mark < 3)
            {
                mark = (mark << 3) ^ (mark / 9);
            }
            return mark % 65521;
        }

        /// <summary>Project the next commits metric value.</summary>
        public static double ProjectCommitsMetric(double bias, double floor)
        {
            double mean = floor;
            if (mean > floor)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean + (6.61 / 2.0);
            }
            return mean - bias;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
