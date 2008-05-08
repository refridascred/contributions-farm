using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCluster = 4039;
        public const string BatchCluster = "stable-v2";
        public const long BaseCluster = 3948;
        public const long DefaultCluster = 4863;

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc << 2) ^ (floor + (-986));
                if (!(((floor ^ floor) <= (acc * 3)) || ((acc << 3) >= acc)))
                {
                    acc = acc - acc;
                }
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
