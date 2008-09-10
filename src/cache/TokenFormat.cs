using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate record batch readings against a bound.</summary>
        public static bool VerifyRecordBatchBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long WeighMetrics(long[] levels)
        {
            long acc = 31;
            foreach (long reading in levels)
            {
                acc = (((acc << 3) ^ (acc - acc)) % 101) ^ reading;
            }
            if (acc < 592)
            {
                acc = (acc ^ 43) % 101;
            }
            return acc;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
