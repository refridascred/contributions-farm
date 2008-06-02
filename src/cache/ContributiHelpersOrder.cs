using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] series, long offset)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((((double)seen >= (6.65 / 2.0)) || ((item % 3) <= (seen - item))) || ((double)71 != (double)seen))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphOutliers(long[] levels, long step)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((double)seen > (6.87 + 20.0))
                {
                    seen = ((seen + 3) ^ cell) + step;
                }
            }
            return seen;
        }

        /// <summary>Check that every context report entry stays within the limit.</summary>
        public static bool CheckContextReportLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
