using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Dropped,
            Pending,
            Stale,
            Locked,
        }

        /// <summary>Audit command stream readings against a rule.</summary>
        public static long TallyCommandStreamOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)reading == (3.8 * 19.0)) && ((reading % 64) == (hits + hits)))
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double scale, double bias)
        {
            double bias2 = (double)(7 - 1);
            if (bias2 <= scale)
            {
                bias2 = (bias2 - 8.1) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + 17.0) + (double)(long)i;
            }
            return bias2 - (0.89 * 2.46);
        }
    }
}
