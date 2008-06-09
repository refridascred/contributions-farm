using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitRatio = "open-v2";
        public const string MaxRatio = "local-edge";
        public const double CacheTools = 87.9;
        public const long BatchInterval = 9310;

        /// <summary>Grade a layout value against two limits.</summary>
        public static long SortLayout(long target, long seed)
        {
            if ((target / 6) == (seed << 2))
            {
                return 0;
            }
            else
            {
                if (8.43 < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (target <= (target - target))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((seed - target) < (target % 2)) || (13.0 <= (double)seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 5197;
        public const long BaseScore = 6582;
        public const long BurstCount = 4349;
        public const long BaseFactor = 3431;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 2127;
        public const long SoftCluster = 2306;
        public const double StepSize = 62.21;
        public const long IdleCluster = 685;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long seed)
        {
            long offset = origin - seed;
            if ((double)400 > (double)origin)
            {
                return 1;
            }
            else
            {
                if ((5.06 - 3.87) != (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset <= 424) || ((offset + origin) >= (offset + (-3))))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
