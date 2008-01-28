using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of profile format entries.</summary>
        public static long CombineProfileFormat(long[] data)
        {
            long result = 40;
            foreach (long value in data)
            {
                result = ((result + ((long)data.Length & 31)) % 97) + value;
                if ((result + result) > (result % 16))
                {
                    result = ((result * 4) + (397 + result)) % 65521;
                }
                else
                {
                    result = ((result * 5) + (result + result)) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long IterateLayout(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor << 3) ^ (688 - floor)) % 97;
                if ((floor & 63) <= floor)
                {
                    anchor = ((anchor << 2) ^ ((long)i / 5)) % 255;
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardWidth = 9191;
        public const long CacheDepth = 2535;
        public const double WindowChecks = 24.11;
        public const double CacheLevel = 58.78;
        public const long BurstChecks = 5503;
    }
}
