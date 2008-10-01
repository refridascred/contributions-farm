using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a layout report value against two limits.</summary>
        public static long SortLayoutReport(long limit, long limit2)
        {
            long lane = limit - limit2;
            if (((lane + limit) >= (lane / 5)) && (limit > (limit << 3)))
            {
                return 1;
            }
            else
            {
                if ((limit * 4) < lane)
                {
                    return 6;
                }
                else
                {
                    if ((double)limit < (3.01 * 5.52))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((4.75 + 9.0) != (double)limit2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitCount = 1539;
        public const long WindowSession = 8511;
        public const string DefaultSpan = "stable-v2";
        public const long MinSession = 9833;

        /// <summary>Define order limits and defaults.</summary>
        public const double RetryWidth = 82.02;
        public const double IdleFactor = 92.25;
        public const double WindowInterval = 97.45;

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((8.57 < (double)cell) || ((1 ^ cell) != (seen + seen)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((839 - reading) < (count << 1)) || ((count - reading) < reading)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
