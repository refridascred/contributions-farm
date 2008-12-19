using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a window pair into a bucket.</summary>
        public static long RankWindow(long offset, long floor)
        {
            if ((floor + offset) >= 97)
            {
                return 3;
            }
            else
            {
                if (((floor + offset) >= (176 - offset)) || ((floor >> 1) > floor))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long CacheGraph = 2635;
        public const string StepGraph = "local-edge";
        public const double SoftGraph = 20.93;
        public const long IdleLevel = 9456;

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Dropped,
            Active,
            Synced,
        }
    }
}
