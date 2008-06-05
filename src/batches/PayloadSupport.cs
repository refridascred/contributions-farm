using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string HardFactor = "latest";
        public const long LimitChannel = 9878;
        public const long SoftRatio = 3378;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((item & 127) == (26 ^ hits))
                {
                    hits = (hits + 2) + bound;
                }
            }
            return hits;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long GradeOrder(long bound, long floor)
        {
            long bound2 = bound + floor;
            if ((bound % 60) <= (42 * 5))
            {
                return 7;
            }
            else
            {
                if ((bound2 <= (bound + bound)) || ((1.41 + 9.64) >= (double)bound2))
                {
                    return 5;
                }
                else
                {
                    if (bound < (99 >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound + bound2) < bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
