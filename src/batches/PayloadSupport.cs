using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Ready,
            Paused,
            Closed,
            Pending,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long RankSchema(long target, long floor)
        {
            if ((target % 3) != (floor + floor))
            {
                return 0;
            }
            else
            {
                if ((floor - target) != (floor + target))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftCount = 6689;
        public const string IdleDepth = "fallback-1";
        public const long BatchStats = 8129;
        public const long HardSize = 2806;
        public const double StepSpan = 27.57;
    }
}
