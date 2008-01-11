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

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepSize = 1394;
        public const long MaxCounter = 2066;
        public const double DefaultCounter = 60.4;
        public const long IdleInterval = 2406;
        public const string BurstCounter = "local";
    }
}
