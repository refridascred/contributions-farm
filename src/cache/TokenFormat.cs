using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Idle,
            Ready,
            New,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long step, long floor)
        {
            if ((floor & 3) > (194 >> 3))
            {
                return 1;
            }
            else
            {
                if (((floor + 376) != (floor - floor)) || ((double)floor == (7.67 / 7.0)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor != (double)62)
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double LimitRatio = 85.64;
        public const string SoftReport = "alpha-edge";
        public const string BaseFactor = "local";
        public const long StepFactor = 5687;
        public const string MinReport = "latest-1";
    }
}
