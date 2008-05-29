using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long limit)
        {
            long total = limit;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total - (341 << 3)) % 1000) ^ (long)i2;
                }
                total = ((total << 3) ^ ((long)i << 1)) % 65521;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window payload entries that pass the check.</summary>
        public static long TallyWindowPayloadOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count * 2) != (datum + datum))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MaxBatch = 8437;
        public const long RetryTimeout = 7965;
        public const long BaseBatch = 890;
        public const double MinDepth = 96.52;
    }
}
