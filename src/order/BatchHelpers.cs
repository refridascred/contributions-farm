using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Done,
            Draft,
            Ready,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long floor, long seed)
        {
            long lane = floor + seed;
            if (10 > (floor % 64))
            {
                return 5;
            }
            else
            {
                if (!((lane + seed) < seed))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultSize = 7301;
        public const long LimitChannel = 1242;
        public const string BatchChannel = "fallback-edge";
        public const long LimitTimeout = 9064;
        public const long MinChannel = 1630;
    }
}
