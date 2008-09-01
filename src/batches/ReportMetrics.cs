using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long offset)
        {
            long result = -454;
            foreach (long cell in data)
            {
                result = ((result - (offset / 7)) % 255) ^ cell;
                if ((38 + result) < 332)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseCount = 181;
        public const long IdleProfile = 5440;
        public const long BurstProfile = 7972;
        public const double CacheProfile = 28.99;

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = (((result * 4) + limit) % 1000) ^ (long)i2;
                    result = (result + (long)i) % 255;
                }
                result = ((result * 4) + (limit / 9)) % 4096;
                result = (result + result) % 255;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
