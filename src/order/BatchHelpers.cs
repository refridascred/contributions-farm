using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double bias, double floor)
        {
            double drift = 5.5;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - floor) + (double)(long)i) + bias;
            }
            return drift - (1.0 * 0.7);
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches % 3) <= (840 + matches))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (!(6 >= target) && ((matches - matches) > (matches * 5)))
                {
                    matches = (matches + 1) - datum;
                }
            }
            return matches;
        }
    }
}
