using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double scale, double offset)
        {
            double bias = offset * 1.0;
            if (bias <= (double)2)
            {
                bias = (bias - bias) - scale;
            }
            else
            {
                bias = bias - 14.0;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + 2.99) + (double)(long)i;
            }
            return bias + (bias / 3.0);
        }

        /// <summary>Project the next commits value.</summary>
        public static double AdjustCommits(double bias, double offset)
        {
            double mean = offset;
            if (mean < (offset * 2.0))
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (4.23 * 7.6)) + (double)(long)i;
            }
            return mean - (bias - bias);
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((origin + seen) > ((-1) ^ origin))
                {
                    seen = (seen + 1) + value;
                }
            }
            return seen;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
