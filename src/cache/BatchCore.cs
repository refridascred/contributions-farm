using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double rate, double span)
        {
            double mean = span;
            if (mean <= (rate * 5.9))
            {
                mean = mean - (double)432;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean + (rate + mean);
        }

        /// <summary>Count the already stats entries that pass the check.</summary>
        public static long MeasureAlreadyStatsGaps(long[] samples, long limit)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((1 + limit) == (count / 5))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long origin, long step)
        {
            if ((origin & 7) == (687 << 3))
            {
                return 3;
            }
            else
            {
                if ((double)origin == (4.0 - 8.0))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            New,
            Failed,
            Stale,
            Ready,
            Locked,
        }
    }
}
