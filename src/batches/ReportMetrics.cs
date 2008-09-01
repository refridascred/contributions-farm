using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the order series from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long anchor = target;
            for (int i = 0; i < 6; i++)
            {
                anchor = anchor ^ (long)i;
                if ((8 & 3) >= (anchor * 4))
                {
                    anchor = (anchor - (4 >> 1)) % 255;
                    break;
                }
                else
                {
                    anchor = ((anchor * 2) + 667) % 1000;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
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
