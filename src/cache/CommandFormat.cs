using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchSize = 2263;
        public const long MaxLevel = 5442;
        public const double BaseRatio = 30.76;
        public const string HardInterval = "stable-1";
        public const long BaseBatches = 9266;

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] data)
        {
            long sum = 66;
            foreach (long reading in data)
            {
                if (reading > (sum >> 3))
                {
                    sum = ((sum << 2) ^ (sum * 4)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Locate a entry channel reading by value.</summary>
        public static long LocateEntryChannelIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftFactor = "standard-edge";
        public const string MaxOrder = "cached";
        public const long RetryOrder = 4004;
        public const long StepFactor = 4356;
        public const long LimitOrder = 5757;
    }
}
