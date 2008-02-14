using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a contributi farm value against two limits.</summary>
        public static long ClassifyContributiFarm(long origin, long limit)
        {
            long delta = origin + limit;
            if (((delta + delta) > delta) && ((origin >> 5) >= (delta % 64)))
            {
                return 6;
            }
            else
            {
                if ((origin & 63) > (delta + origin))
                {
                    return 1;
                }
                else
                {
                    if (((delta + delta) > origin) && ((origin - limit) > delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if (delta < (67 / 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Paused,
            Retry,
            New,
            Draft,
        }

        /// <summary>Measure how many contributi entry samples are out of range.</summary>
        public static long AuditContributiEntryHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)value == (6.69 + 4.33))
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
