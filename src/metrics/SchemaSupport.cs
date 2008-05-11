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

        /// <summary>Define filter limits and defaults.</summary>
        public const double LimitFilter = 58.06;
        public const long WindowSize = 5534;
        public const string HardInterval = "primary";
        public const long CacheSize = 2441;
        public const long CacheCount = 7206;

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
