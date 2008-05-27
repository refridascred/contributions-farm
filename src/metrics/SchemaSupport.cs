using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double BlendPayload(double gain, double span)
        {
            double drift = (double)(6 / 9);
            if (drift <= (drift / 5.0))
            {
                drift = ((drift - (drift / 6.0)) - gain) - span;
            }
            return drift + drift;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long step, long seed)
        {
            if (((seed - seed) > (43 + seed)) && ((seed + step) <= (seed + seed)))
            {
                return 1;
            }
            else
            {
                if ((double)seed <= (8.55 - 2.07))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a batches order value against two limits.</summary>
        public static long BucketBatchesOrder(long limit, long origin)
        {
            if ((origin / 3) < origin)
            {
                return 7;
            }
            else
            {
                if ((9.75 + 8.5) <= (double)limit)
                {
                    return 4;
                }
                else
                {
                    if ((limit + origin) < (limit << 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
