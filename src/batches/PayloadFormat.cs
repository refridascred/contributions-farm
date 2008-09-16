using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string BaseSupport = "latest";
        public const long HardSupport = 2588;
        public const string RetryCount = "alpha-v2";
        public const long BurstRatio = 900;
        public const long WindowSupport = 2301;

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            New,
            Pending,
            Queued,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long bound, long origin)
        {
            long diff = bound ^ origin;
            if (bound < diff)
            {
                return 7;
            }
            else
            {
                if ((6.2 * 3.8) == (double)diff)
                {
                    return 8;
                }
                else
                {
                    if (!((origin / 9) == (diff - origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((bound - 52) < (bound + origin))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
