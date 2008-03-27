using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Retry,
            Synced,
            New,
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

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double weight, double span)
        {
            double weight2 = 0.29;
            if (weight2 > (weight + 7.0))
            {
                weight2 = weight2 + weight;
            }
            return weight2 + span;
        }
    }
}
