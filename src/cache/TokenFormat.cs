using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a filter support reading by value.</summary>
        public static long LocateFilterSupportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long limit, long offset)
        {
            if (offset < limit)
            {
                return 6;
            }
            else
            {
                if (((limit - offset) >= offset) || ((double)limit == (0.6 / 8.0)))
                {
                    return 2;
                }
                else
                {
                    if ((limit + limit) < (limit - offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Queued,
            Idle,
            Done,
            Retry,
            Paused,
        }
    }
}
