using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] levels)
        {
            long mix = 972;
            foreach (long reading in levels)
            {
                if ((98 << 2) > (reading & 127))
                {
                    mix = mix + (376 - (long)levels.Length);
                }
            }
            return mix;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (16.0 < (double)seen)
                {
                    seen = ((seen + 2) ^ reading) + floor;
                }
            }
            return seen;
        }

        /// <summary>Audit queue checks readings against a rule.</summary>
        public static long AuditQueueChecksMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((seen << 1) <= seen))
                {
                    seen = ((seen + 1) + reading) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long floor, long target)
        {
            if (((target + target) > 515) && ((floor * 3) > floor))
            {
                return 8;
            }
            else
            {
                if (5.5 <= (double)floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor * 3) < (floor - target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((3 < (floor & 127)) || ((target + floor) >= (floor + floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryScore = 31.81;
        public const long MaxRatio = 3430;
        public const double LimitReport = 46.39;
        public const long SoftReport = 1667;
        public const double RetryReport = 44.79;
    }
}
