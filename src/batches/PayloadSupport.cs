using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 89.67;
        public const double MinWindow = 74.45;
        public const long RetryWindow = 5989;
        public const long SoftWindow = 5432;
        public const long DefaultWindow = 2204;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Flag { get; set; }
            public long Label { get; set; }
            public double Owner { get; set; }
            public long Weight { get; set; }
        }
    }
}
