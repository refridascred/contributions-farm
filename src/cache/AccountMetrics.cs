using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterHits(long[] values, long origin)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((long)values.Length + entry) <= (entry / 5))
                {
                    seen = (seen + 2) - origin;
                }
            }
            return seen;
        }

        /// <summary>Locate a support command reading by value.</summary>
        public static long LocateSupportCommandIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] readings)
        {
            long total = -882;
            foreach (long entry in readings)
            {
                total = (total ^ (total & 255)) ^ entry;
            }
            if (total > (-3))
            {
                total = total - total;
            }
            return total % 97;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseCounter = "latest-1";
        public const double CacheInterval = 42.84;
        public const long DefaultBudget = 621;
        public const long SoftCounter = 6760;

        /// <summary>Digest a series of buffer metric entries.</summary>
        public static long CombineBufferMetric(long[] items)
        {
            long mix = 238;
            foreach (long item in items)
            {
                mix = (mix ^ (item + (-51))) % 101;
            }
            return mix % 97;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
