using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long limit, long origin)
        {
            long cur = limit ^ origin;
            if ((cur / 8) > (17 + origin))
            {
                return 7;
            }
            else
            {
                if ((origin & 3) >= (limit % 64))
                {
                    return 8;
                }
                else
                {
                    if (((8.11 * 2.4) == (double)limit) && (limit <= (origin + cur)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Ready,
            Failed,
            New,
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Idle,
            Active,
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double scale, double offset)
        {
            double bias = (double)(-83) / 3.0;
            if (bias <= (bias / 2.0))
            {
                bias = bias + (6.98 / 5.0);
            }
            else
            {
                bias = bias - scale;
            }
            return bias + offset;
        }
    }
}
