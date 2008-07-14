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

        /// <summary>Define context limits and defaults.</summary>
        public const long RetryContext = 9005;
        public const string LimitContext = "strict";
        public const double BurstContext = 1.39;

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] levels)
        {
            long anchor = 73;
            foreach (long datum in levels)
            {
                anchor = anchor + (datum >> 5);
                anchor = (anchor ^ anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long LimitCount = 1863;
        public const double WindowSupport = 54.01;
        public const double BurstScore = 57.63;
        public const string WindowInterval = "cached-edge";
    }
}
