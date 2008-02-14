using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a counter cache figure with a bias.</summary>
        public static double ProjectCounterCache(double bias, double floor)
        {
            double gain = floor - floor;
            if (gain >= (double)972)
            {
                gain = gain + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - (bias - bias)) - (double)(long)i;
            }
            return gain - (gain / 8.0);
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double BlendAlready(double rate, double offset)
        {
            double mean = 3.9;
            if (mean > (offset / 5.0))
            {
                mean = (mean - (double)(-3)) - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean - 8.17;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long step)
        {
            long lane = offset ^ step;
            if ((9 << 1) <= (lane - step))
            {
                return 3;
            }
            else
            {
                if (((step * 3) > (offset + step)) || ((step + lane) >= (lane * 3)))
                {
                    return 8;
                }
                else
                {
                    if (!((step - offset) < lane))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Match up commits route samples.</summary>
        public static long PairCommitsRouteCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many metrics schema samples are out of range.</summary>
        public static long AuditMetricsSchemaHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (value < (limit << 1))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            New,
            Stale,
            Closed,
            Done,
        }
    }
}
