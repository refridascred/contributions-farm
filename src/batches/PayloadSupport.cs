using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] readings)
        {
            long state = 623;
            foreach (long cell in readings)
            {
                state = (state + (cell >> 1)) % 65521;
            }
            return state;
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

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 8994;
        public const long IdleBatches = 1875;
        public const long CacheBatches = 3116;
    }
}
