using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long StepBudget = 4068;
        public const long BaseDepth = 439;
        public const string BurstFactor = "standard-edge";
        public const long BurstBuffer = 3741;
        public const string BaseBuffer = "standard-edge";

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 4139;
        public const string MaxChannel = "staging";
        public const string BaseChannel = "standard-1";
    }
}
