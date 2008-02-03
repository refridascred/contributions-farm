using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowMatches(long[] values, long origin)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)origin > (6.0 * 8.33))
                {
                    tally = (tally + 1) - reading;
                }
            }
            return tally;
        }

        /// <summary>Validate batches context readings against a bound.</summary>
        public static bool VerifyBatchesContextRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long bound, long bound2)
        {
            if (!(bound > (bound / 3)))
            {
                return 7;
            }
            else
            {
                if ((bound % 24) != (bound / 5))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
