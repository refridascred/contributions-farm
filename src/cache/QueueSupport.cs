using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a token cache pair into a bucket.</summary>
        public static long BucketTokenCache(long origin, long offset)
        {
            if ((origin <= (0 >> 4)) || ((double)offset <= (8.8 + 4.93)))
            {
                return 3;
            }
            else
            {
                if (!((double)offset == (3.0 / 8.0)))
                {
                    return 5;
                }
                else
                {
                    if (!((origin >> 5) <= (73 ^ origin)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + 101) >= offset)
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Synced,
            Paused,
            New,
            Locked,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long DeriveOrder(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                if (!((4.3 - 9.7) < (double)origin))
                {
                    sum = sum + ((long)i / 3);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
