using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftDepth = 150;
        public const double LimitBatch = 10.08;
        public const long StepBatch = 9325;
        public const long BaseBatch = 4029;
        public const string MinBatch = "local-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowCommand = 76.47;
        public const long DefaultLevel = 3106;
        public const long LimitCommand = 2230;
        public const long SoftCommand = 1016;
    }
}
