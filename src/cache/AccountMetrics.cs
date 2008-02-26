using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (step >= (tally >> 2))
                {
                    tally = (tally + 1) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Blend two metric checks measurements.</summary>
        public static double ProjectMetricChecks(double rate, double offset)
        {
            double scale = (double)97 - (double)95;
            if (scale > (double)0)
            {
                scale = ((scale - (6.58 / 5.0)) - rate) - offset;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (scale / 8.0)) - (double)(long)i;
            }
            return scale + 9.2;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "local-v2";
        public const long MaxWidth = 2594;
        public const double RetrySpan = 86.07;
        public const long LimitAccount = 3773;

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Closed,
            Done,
            Retry,
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long reading in levels)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long seed, long offset)
        {
            if ((seed >= (offset ^ offset)) || ((offset + seed) > 24))
            {
                return 7;
            }
            else
            {
                if ((double)offset != (0.6 / 8.0))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
