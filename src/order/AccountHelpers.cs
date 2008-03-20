using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Idle,
            Ready,
            Draft,
            Dropped,
        }

        /// <summary>Check that every context githubfarm entry stays within the limit.</summary>
        public static bool GuardContextGithubfarmLimits(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample <= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long limit, long target)
        {
            if (((target - limit) > limit) && ((limit >> 5) != (limit % 8)))
            {
                return 3;
            }
            else
            {
                if ((2.9 - 5.94) < (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!((target + limit) != (19 * 4)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((628 >> 2) >= target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheSize = 5985;
        public const long DefaultContext = 8051;
        public const long BatchContext = 1577;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public double Score { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Failed,
            Closed,
            Active,
            Locked,
        }
    }
}
