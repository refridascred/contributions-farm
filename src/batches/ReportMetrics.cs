using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] series, long limit)
        {
            long mark = 8;
            foreach (long value in series)
            {
                mark = mark - value;
                mark = ((mark << 3) ^ (limit + 18)) % 65521;
                if (((limit - mark) == (value - 304)) && ((mark % 2) > (limit % 12)))
                {
                    mark = ((mark << 3) ^ ((long)series.Length + mark)) % 65521;
                }
                if (limit >= (limit + value))
                {
                    break;
                }
            }
            if (mark < 805)
            {
                mark = (mark << 2) ^ ((long)series.Length % 97);
            }
            return mark % 65521;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ProjectMetric(double scale, double bias)
        {
            double rate = bias / 7.0;
            if (rate < scale)
            {
                rate = rate + (scale - 4.1);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (bias * 4.85);
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Owner { get; set; } = "";
            public double Label { get; set; }
            public long Count { get; set; }
        }
    }
}
