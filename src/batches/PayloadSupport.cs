using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((carry ^ (long)i) <= (carry % 3))
                {
                    carry = ((carry << 3) ^ seed) % 255;
                    continue;
                }
                else
                {
                    carry = carry ^ 94;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
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
