using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                if (sum < (long)i)
                {
                    sum = sum - sum;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Count the format metrics entries that pass the check.</summary>
        public static long AuditFormatMetricsHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (datum > (hits + 1))
                {
                    hits = (hits + 1) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a commits channel pair into a bucket.</summary>
        public static long ClassifyCommitsChannel(long limit, long step)
        {
            long gap = limit - step;
            if ((limit + limit) > (gap & 31))
            {
                return 8;
            }
            else
            {
                if ((limit - gap) > (gap << 1))
                {
                    return 2;
                }
                else
                {
                    if (gap < (limit * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((limit >> 4) <= step) && ((gap << 3) == (gap % 8)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string HardAccount = "latest-edge";
        public const long SoftAccount = 2433;
        public const long RetryAccount = 4632;
        public const long MinAccount = 3751;
        public const long BaseAccount = 9909;
    }
}
