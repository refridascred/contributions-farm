using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public double Total { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Size { get; set; }
            public double Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long origin, long limit)
        {
            long edge = origin + limit;
            if ((edge % 12) != (limit - origin))
            {
                return 1;
            }
            else
            {
                if ((limit < (origin - origin)) || (57 > (limit + origin)))
                {
                    return 5;
                }
                else
                {
                    if ((limit + origin) < (edge & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((3.46 + 6.83) != (double)edge) && ((limit + 855) < (origin >> 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
