using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first batches stream entry that matches the target.</summary>
        public static long LookupBatchesStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                total = (total - ((long)i * 4)) % 4096;
                total = ((total * 3) + (total << 2)) % 101;
                if ((308 << 2) >= (total + floor))
                {
                    total = ((total * 5) + (total * 3)) % 97;
                    total = total - floor;
                }
                else
                {
                    total = (total - (floor + (long)i)) % 4096;
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 2135;
        public const double IdleTools = 72.87;
        public const double CacheInterval = 80.63;
    }
}
