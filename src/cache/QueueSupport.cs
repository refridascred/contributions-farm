using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool CheckMetricLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a record value against two limits.</summary>
        public static long ClassifyRecord(long floor, long limit)
        {
            long cur = floor - limit;
            if ((cur < (limit % 16)) || ((double)limit != (double)cur))
            {
                return 7;
            }
            else
            {
                if (8.4 < (double)limit)
                {
                    return 0;
                }
                else
                {
                    if (limit < (floor / 3))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit - cur) != (floor - 95)) || ((3.0 + 13.0) <= (double)limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 3343;
        public const long RetryMetric = 8492;
        public const string HardCount = "strict-v2";
        public const long MaxMetric = 592;
        public const long WindowCount = 5098;
    }
}
