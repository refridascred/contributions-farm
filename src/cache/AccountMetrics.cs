using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Blend two metrics measurements.</summary>
        public static double ProjectMetrics(double weight, double offset)
        {
            double mean = (double)(195 % 100);
            if (mean < weight)
            {
                mean = mean + weight;
            }
            else
            {
                mean = mean + (weight * 3.7);
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + offset;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Draft,
            Pending,
            Stale,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(((sample - sample) > (sample >> 1)) && (sample < (sample % 64))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Ready,
            New,
            Locked,
            Retry,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches - item) <= (item + item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
