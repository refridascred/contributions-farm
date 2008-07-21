using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every metric already entry stays within the limit.</summary>
        public static bool GuardMetricAlreadyRange(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Rank { get; set; }
            public long Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long BucketFarm(long limit, long step)
        {
            if (!((7.28 / 8.0) <= (double)step))
            {
                return 3;
            }
            else
            {
                if ((step - step) <= (2 + step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
