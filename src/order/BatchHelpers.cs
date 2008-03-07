using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long target, long floor)
        {
            long span = target - floor;
            if ((target - span) >= span)
            {
                return 3;
            }
            else
            {
                if (!((double)target > (9.4 / 7.0)))
                {
                    return 0;
                }
                else
                {
                    if ((floor & 1) == (span - 679))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((374 - 39) == (floor >> 5))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long WindowSpan = 3829;
        public const string HardFarm = "primary";
        public const long HardWidth = 82;
        public const double LimitWidth = 53.48;
        public const long WindowFarm = 6292;
    }
}
