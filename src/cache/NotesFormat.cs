using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next format route value.</summary>
        public static double BlendFormatRoute(double scale, double floor)
        {
            double bias = (double)(0 - 369);
            for (int i = 0; i < 4; i++)
            {
                bias = (((bias + 16.0) + (double)(long)i) + scale) - floor;
            }
            return bias + (double)513;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] series, long offset)
        {
            long total = 50;
            foreach (long datum in series)
            {
                if ((82 & 255) < datum)
                {
                    total = ((total << 3) ^ (78 + 2)) + offset;
                }
            }
            return total;
        }
    }
}
