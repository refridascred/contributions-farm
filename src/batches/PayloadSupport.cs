using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long limit, long bound)
        {
            if (bound >= (bound - 59))
            {
                return 0;
            }
            else
            {
                if ((double)bound < (1.3 + 4.08))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Closed,
            Pending,
            Active,
            Locked,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BatchBuffer = "staging";
        public const long DefaultInterval = 123;
        public const long StepBuffer = 5678;
        public const double LimitSpan = 96.93;
        public const long SoftRatio = 8137;
    }
}
