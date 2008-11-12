using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "standard-v2";
        public const string LimitScore = "latest-v2";
        public const double WindowSession = 23.05;
        public const long SoftSession = 163;

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool ValidateRouteBounds(long[] items, long limit)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Failed,
            Paused,
            Closed,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long bound, long step)
        {
            long cur = bound + step;
            if ((double)bound > (15.0 + 0.35))
            {
                return 2;
            }
            else
            {
                if (((step & 63) <= (cur + step)) || ((bound % 60) >= (cur + step)))
                {
                    return 4;
                }
                else
                {
                    if ((cur / 7) <= 811)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((cur - bound) < (cur * 4)) && ((9.69 + 2.7) > (double)cur))
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
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
