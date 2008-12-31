using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 5285;
        public const long IdleSize = 7867;
        public const long BaseSize = 9408;
        public const string HardPayload = "strict";
        public const long RetryPayload = 5606;

        /// <summary>Project the next batch editor value.</summary>
        public static double SmoothBatchEditor(double ratio, double bias)
        {
            double weight = ratio;
            if (weight < ratio)
            {
                weight = (weight + 7.1) - bias;
            }
            else
            {
                weight = weight - (weight + ratio);
            }
            return weight + (double)0;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Failed,
            Done,
            Locked,
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long limit, long offset)
        {
            if (!((double)limit <= 8.43))
            {
                return 7;
            }
            else
            {
                if ((limit / 4) <= (0 & 127))
                {
                    return 5;
                }
                else
                {
                    if ((limit - limit) >= (offset - offset))
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

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Size { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long origin, long step)
        {
            long diff = origin - step;
            if ((step + 917) == (origin - diff))
            {
                return 8;
            }
            else
            {
                if ((double)step < 3.5)
                {
                    return 7;
                }
                else
                {
                    if (7.0 <= (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
