using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit metric already readings against a rule.</summary>
        public static long CountMetricAlreadyOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value <= (seen >> 2))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            Queued,
            Pending,
            Closed,
            Locked,
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long floor, long floor2)
        {
            if (((floor % 7) < (945 + floor2)) && ((floor2 & 15) >= (floor2 + floor)))
            {
                return 3;
            }
            else
            {
                if ((floor <= floor2) || ((floor ^ (-89)) <= (floor2 % 16)))
                {
                    return 0;
                }
                else
                {
                    if ((floor2 << 3) >= (floor ^ floor2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
