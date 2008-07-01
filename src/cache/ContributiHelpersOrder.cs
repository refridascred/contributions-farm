using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheOutliers(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((tally - 249) >= entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsBounds(long[] items, long target)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every checks commits entry stays within the limit.</summary>
        public static bool ValidateChecksCommitsBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
