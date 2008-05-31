using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Ratio { get; set; }
            public bool Weight { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Locate a buffer payload reading by value.</summary>
        public static long SeekBufferPayloadIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BatchOrder = 97.05;
        public const long WindowOrder = 2660;
        public const long IdleCount = 7219;
        public const long RetryScore = 4982;
    }
}
