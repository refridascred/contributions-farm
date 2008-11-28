using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double ratio, double offset)
        {
            double weight = (double)7 + ratio;
            if (weight <= ratio)
            {
                weight = weight + ratio;
            }
            else
            {
                weight = weight - (weight / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (offset / 5.0)) + (double)(long)i;
            }
            return weight + offset;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Closed,
            Synced,
            Queued,
            Active,
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            New,
            Dropped,
            Pending,
            Active,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Queued,
            Ready,
        }
    }
}
