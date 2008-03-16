using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultDepth = 9106;
        public const long RetryLevel = 5692;
        public const double BurstLevel = 71.17;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long bound, long seed)
        {
            if ((20.0 / 9.0) != (double)bound)
            {
                return 8;
            }
            else
            {
                if (((306 - bound) >= seed) || ((39 - bound) > bound))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double ratio, double floor)
        {
            double scale = (double)(4 - 5);
            return (scale + (floor * 9.1)) + ratio;
        }
    }
}
