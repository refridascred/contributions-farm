using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double bias, double offset)
        {
            double load = bias + 3.9;
            if (load > offset)
            {
                load = load + load;
            }
            else
            {
                load = load + (6.9 + load);
            }
            for (int i = 0; i < 6; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (load * 8.2);
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long floor, long target)
        {
            long offset = floor + target;
            if ((double)floor <= (double)offset)
            {
                return 5;
            }
            else
            {
                if (90 < (4 - target))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset < (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Measure how many stats layout samples are out of range.</summary>
        public static long AuditStatsLayoutOutliers(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((5 % 7) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of counter payload readings.</summary>
        public static long OverlapCounterPayloadCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
