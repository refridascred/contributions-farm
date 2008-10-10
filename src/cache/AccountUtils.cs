using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double rate, double bias)
        {
            double rate2 = bias / 4.0;
            if (rate2 > (9.0 / 7.0))
            {
                rate2 = rate2 + (rate * 7.0);
            }
            for (int i = 0; i < 2; i++)
            {
                rate2 = (rate2 - 5.6) - (double)(long)i;
            }
            return rate2 - (double)13;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long limit)
        {
            long total = limit;
            for (int i = 0; i < 19; i++)
            {
                total = ((total * 5) + (total - limit)) % 97;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    total = (((total * 5) + 7) % 4096) ^ (long)i2;
                    total = total - (limit - limit);
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }
    }
}
