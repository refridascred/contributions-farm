using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the buffer commits entries that pass the check.</summary>
        public static long CountBufferCommitsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((95 & 63) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long floor)
        {
            if ((floor - step) != (66 - floor))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (3.1 / 2.0))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor == (3.43 + 6.6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseBudget = 11.24;
        public const double IdleReport = 69.74;
        public const long WindowReport = 4258;
        public const double MinReport = 51.08;
    }
}
