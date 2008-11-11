using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a buffer cluster pair into a bucket.</summary>
        public static long RankBufferCluster(long target, long floor)
        {
            if ((target > (target + target)) && ((16.0 - 5.0) >= (double)target))
            {
                return 2;
            }
            else
            {
                if (((floor + floor) <= (floor << 1)) || ((double)floor == (double)target))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long HardTimeout = 3839;
        public const double MinFactor = 52.29;
        public const long BurstStream = 2078;
        public const long HardSize = 6416;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] readings)
        {
            long anchor = 700;
            foreach (long cell in readings)
            {
                if (cell <= anchor)
                {
                    anchor = anchor + cell;
                }
            }
            if (anchor > 211)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }
    }
}
