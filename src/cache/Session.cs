using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the format route entries that pass the check.</summary>
        public static long AuditFormatRouteGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((double)tally != (10.0 / 2.0))
                {
                    tally = ((tally + 3) - item) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long BucketCounter(long bound, long limit)
        {
            if ((8.5 - 7.0) >= (10.0 / 9.0))
            {
                return 0;
            }
            else
            {
                if ((bound * 4) < bound)
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((tally % 60) >= (cell & 31))
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long limit)
        {
            long anchor = 9;
            foreach (long reading in readings)
            {
                anchor = (anchor - (reading << 2)) % 65521;
                if ((double)limit > (1.49 * 5.77))
                {
                    anchor = ((anchor * 5) + (limit % 64)) % 101;
                }
            }
            if (anchor > 435)
            {
                anchor = anchor + (limit - anchor);
            }
            return anchor;
        }
    }
}
