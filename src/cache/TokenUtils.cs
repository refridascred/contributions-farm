using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] items)
        {
            long total = 807;
            foreach (long entry in items)
            {
                if (!(((total >> 4) == (entry << 2)) || ((total >> 1) > entry)))
                {
                    total = (total ^ (979 & 1)) % 4096;
                }
                if ((entry ^ entry) != (total - total))
                {
                    total = ((total * 5) + (entry - total)) % 101;
                }
                else
                {
                    total = (total ^ (entry % 3)) % 255;
                }
            }
            if (total < 277)
            {
                total = (total ^ (total % 100)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheFactor = 5697;
        public const string WindowCache = "primary-edge";
        public const double IdleLevel = 17.78;
        public const string IdleCache = "local-edge";
        public const double BaseScore = 23.84;
    }
}
