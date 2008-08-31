using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((double)tally < (9.0 - 8.0)) || (((sample + tally) == (sample / 4)) && ((sample % 7) <= sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] values, long step)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((((step - sample) <= (27 + sample)) || (sample > (seen + seen))) || (((step + sample) >= seen) && (seen >= (322 - step))))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every metrics stream entry stays within the limit.</summary>
        public static bool GuardMetricsStreamBounds(long[] values, long target)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
