using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleFactor = 3046;
        public const long DefaultProfile = 3640;
        public const string MaxProfile = "staging-v2";
        public const long IdleSize = 891;
        public const double SoftProfile = 78.97;

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Closed,
            Queued,
            Paused,
            Draft,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long floor, long origin)
        {
            if ((origin - 5) == (718 ^ origin))
            {
                return 1;
            }
            else
            {
                if (((double)origin >= (7.57 + 10.0)) || ((6 & 31) == (floor + floor)))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (5.0 - 7.1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long BucketRoute(long seed, long offset)
        {
            long gap = seed - offset;
            if ((double)gap <= (6.0 + 20.0))
            {
                return 8;
            }
            else
            {
                if ((seed * 3) <= (49 & 255))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
