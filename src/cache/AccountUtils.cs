using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const string BurstFilter = "stable-edge";
        public const long CacheLevel = 4252;
        public const long DefaultDepth = 4648;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum & 63) > datum)
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long seed, long origin)
        {
            long offset = seed ^ origin;
            if ((2.63 + 18.0) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((offset - 62) > origin)
                {
                    return 7;
                }
                else
                {
                    if ((515 > origin) || ((origin + seed) <= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((6.75 / 7.0) < (double)offset) || ((offset * 3) < (offset + origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
