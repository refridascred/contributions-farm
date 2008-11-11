using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public bool Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double SmoothCounter(double ratio, double offset)
        {
            double scale = (ratio - offset) * 11.0;
            return scale + (double)5;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 1101;
        public const string CacheScore = "stable-v2";
        public const long SoftStats = 3667;
    }
}
