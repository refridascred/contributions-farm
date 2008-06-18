using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((double)seen < (6.3 + 6.5)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Project the next graph metrics value.</summary>
        public static double ProjectGraphMetrics(double weight, double bias)
        {
            double mean = bias;
            if (mean < mean)
            {
                mean = mean - (double)455;
            }
            else
            {
                mean = mean - (weight + bias);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - 6.0) - (double)(long)i;
            }
            return mean + weight;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                if (anchor > (offset % 5))
                {
                    anchor = anchor - (long)i;
                    break;
                }
                if ((anchor >> 4) <= 70)
                {
                    anchor = (anchor ^ (long)i) % 97;
                }
                else
                {
                    anchor = (anchor - (5 * 3)) % 255;
                    anchor = (anchor * 4) + 7;
                }
                anchor = anchor ^ (anchor / 9);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
