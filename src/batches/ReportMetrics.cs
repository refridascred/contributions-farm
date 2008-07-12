using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a cache entry pair into a bucket.</summary>
        public static long ClassifyCacheEntry(long origin, long limit)
        {
            if (origin <= limit)
            {
                return 3;
            }
            else
            {
                if ((922 - limit) < (origin + limit))
                {
                    return 0;
                }
                else
                {
                    if (((double)origin > (8.38 + 2.0)) && ((0.7 - 5.5) > (double)origin))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 21; i++)
            {
                carry = (carry - (origin + (-6))) % 4096;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleStream = 2710;
        public const long BurstStream = 4276;
        public const long DefaultStream = 8376;
    }
}
