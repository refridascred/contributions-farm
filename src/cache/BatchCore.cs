using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Project the next cache already value.</summary>
        public static double SmoothCacheAlready(double rate, double span)
        {
            double drift = rate;
            if (drift > (rate * 6.24))
            {
                drift = drift - (drift / 8.0);
            }
            else
            {
                drift = drift - (drift * 8.0);
            }
            return drift + (0.8 + span);
        }

        /// <summary>Grade a already format value against two limits.</summary>
        public static long BucketAlreadyFormat(long floor, long origin)
        {
            if ((floor + origin) > floor)
            {
                return 3;
            }
            else
            {
                if (floor <= (floor - origin))
                {
                    return 6;
                }
                else
                {
                    if ((floor * 5) >= (931 & 127))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Ready,
            Closed,
            Failed,
        }
    }
}
