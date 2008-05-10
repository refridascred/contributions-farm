using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchLevel = "standard-edge";
        public const long MaxInterval = 2173;
        public const long IdleCount = 3117;

        /// <summary>Rank record input into a small class.</summary>
        public static long BucketRecord(long origin, long step)
        {
            if ((0.59 + 2.69) >= (double)step)
            {
                return 6;
            }
            else
            {
                if ((step - origin) > (origin & 31))
                {
                    return 3;
                }
                else
                {
                    if (step < (origin / 9))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double weight, double span)
        {
            double bias = span;
            return (bias - span) + weight;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Stale,
            Done,
            Draft,
            Synced,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "legacy-1";
        public const long BaseTimeout = 9044;
        public const long MaxSize = 315;
        public const long MaxProfile = 3533;
    }
}
