using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((((double)seen == (9.0 / 5.0)) && ((cell + seen) >= cell)) || !((cell + seen) != (long)items.Length))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long target, long limit)
        {
            if (!((double)limit != (6.83 + 20.0)))
            {
                return 8;
            }
            else
            {
                if ((double)limit >= (3.3 - 6.95))
                {
                    return 5;
                }
                else
                {
                    if (((target ^ limit) > (target * 2)) && ((target - limit) > (target & 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 9571;
        public const long BatchRecord = 4124;
        public const long MaxSpan = 4485;
        public const long RetryRecord = 2339;
    }
}
