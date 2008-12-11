using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Closed,
            Queued,
            Dropped,
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long BucketBuffer(long floor, long origin)
        {
            long next = floor + origin;
            if ((next ^ floor) > origin)
            {
                return 2;
            }
            else
            {
                if (18.0 >= (double)next)
                {
                    return 1;
                }
                else
                {
                    if (!(next < (81 + 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] series)
        {
            long score = 293;
            foreach (long value in series)
            {
                score = ((score << 3) ^ score) - value;
                score = (score + ((long)series.Length & 127)) % 65521;
            }
            return score;
        }
    }
}
