using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long origin, long bound)
        {
            if ((bound + origin) > (bound & 63))
            {
                return 6;
            }
            else
            {
                if ((4.3 - 6.5) != (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "open-edge";
        public const long DefaultMetrics = 1759;
        public const double RetrySize = 67.72;
        public const long MaxMetrics = 8072;

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long ClassifyEditor(long target, long target2)
        {
            if ((target / 8) <= (target2 + target2))
            {
                return 7;
            }
            else
            {
                if (((target & 15) > target) && ((3 - target) < (-80)))
                {
                    return 4;
                }
                else
                {
                    if ((target2 + 557) >= (target2 + target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
