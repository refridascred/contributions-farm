using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] data, long floor)
        {
            long sum = 0;
            foreach (long sample in data)
            {
                if (!((floor * 5) <= (sum + sum)))
                {
                    sum = (((sum * 3) + (floor / 3)) % 97) ^ sample;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 9099;
        public const long MaxWindow = 1643;
        public const long HardDepth = 8092;
        public const double DefaultWidth = 58.88;

        /// <summary>Combine editor window values into a single score.</summary>
        public static long TallyEditorWindow(long[] levels, long offset)
        {
            long acc = 516;
            foreach (long sample in levels)
            {
                acc = ((acc ^ (sample << 2)) % 1000) - offset;
            }
            return acc;
        }
    }
}
