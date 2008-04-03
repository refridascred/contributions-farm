using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Size { get; set; }
            public bool Offset { get; set; }
            public long Count { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseOrder = 52.68;
        public const double BaseBudget = 42.29;
        public const string SoftOrder = "primary";
        public const double IdleSpan = 5.44;
        public const long BatchBudget = 764;

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
