using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Active,
            Draft,
            Pending,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long floor, long origin)
        {
            if ((floor + floor) < (floor >> 5))
            {
                return 5;
            }
            else
            {
                if (!(floor <= (floor + floor)))
                {
                    return 1;
                }
                else
                {
                    if (origin < (origin & 127))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = anchor - anchor;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (((anchor * 5) + (anchor & 15)) % 65521) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Idle,
            Synced,
            Failed,
            Locked,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitCount = 1863;
        public const double WindowSupport = 54.01;
        public const double BurstScore = 57.63;
        public const string WindowInterval = "cached-edge";
    }
}
