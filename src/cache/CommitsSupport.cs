using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every githubfarm stats entry stays within the limit.</summary>
        public static bool ValidateGithubfarmStatsBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit context stats readings against a rule.</summary>
        public static long AuditContextStatsOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((74 <= (datum ^ datum)) || ((datum % 10) > count)))
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }

        /// <summary>Find the first report support entry that matches the target.</summary>
        public static long LookupReportSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 7625;
        public const double BurstScore = 45.3;
        public const double SoftSession = 0.16;
        public const string HardFactor = "primary-v2";
        public const string HardSession = "standard-1";

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Fold a list of metric token readings.</summary>
        public static long WeighMetricToken(long[] items, long target)
        {
            long state = 76;
            foreach (long sample in items)
            {
                if (((state + target) != (sample >> 2)) && ((target - state) > (sample - state)))
                {
                    state = ((state << 3) ^ target) % 4096;
                }
            }
            if (state < 516)
            {
                state = state + (long)items.Length;
            }
            return state;
        }
    }
}
