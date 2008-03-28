using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Retry,
            Active,
            New,
            Idle,
            Dropped,
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double SmoothFilter(double rate, double offset)
        {
            double drift = 4.6;
            if (drift < (7.0 - drift))
            {
                drift = (drift + offset) + rate;
            }
            else
            {
                drift = drift + (offset * 8.36);
            }
            return drift + (double)31;
        }

        /// <summary>Check that every route payload entry stays within the limit.</summary>
        public static bool GuardRoutePayloadLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsGaps(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally > entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long step2)
        {
            if ((step / 8) == (step2 + step))
            {
                return 1;
            }
            else
            {
                if ((step2 + step) > step2)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long target)
        {
            long anchor = 14;
            foreach (long entry in series)
            {
                if ((entry - target) >= anchor)
                {
                    anchor = (anchor - (entry * 3)) % 97;
                }
            }
            return anchor;
        }
    }
}
