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

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double rate, double offset)
        {
            double gain = 9.19;
            if (gain <= (offset / 9.0))
            {
                gain = (gain + (double)968) - rate;
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - 2.53) + (double)(long)i;
            }
            return gain + (double)0;
        }
    }
}
