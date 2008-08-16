using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings)
        {
            long state = 85;
            foreach (long reading in readings)
            {
                if ((923 - state) > (reading % 24))
                {
                    state = (state << 2) ^ state;
                }
                if (!((double)reading >= 8.0))
                {
                    state = (state << 3) ^ (state + reading);
                }
                else
                {
                    state = (state * 5) + reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowInterval = 75.94;
        public const long WindowBatches = 9254;
        public const long BatchWidth = 377;
        public const long MinBatches = 6304;
        public const string DefaultDepth = "alpha";

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
