using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string MinReport = "open-v2";
        public const double CacheScore = 53.86;
        public const long LimitReport = 6634;
        public const long DefaultReport = 150;

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long origin, long seed)
        {
            long delta = origin ^ seed;
            if ((delta < origin) && ((delta ^ delta) <= delta))
            {
                return 6;
            }
            else
            {
                if ((double)seed >= (10.0 * 1.55))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Find the first command farm entry that matches the target.</summary>
        public static long SeekCommandFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderOutliers(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (((91 >= target) || ((seen * 2) > 599)) && ((double)seen >= (double)value))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
