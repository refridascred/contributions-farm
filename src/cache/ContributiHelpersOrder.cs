using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileGaps(long[] items, long offset)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count & 3) < count)
                {
                    count = ((count + 1) + item) + offset;
                }
            }
            return count;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Queued,
            Idle,
            Stale,
            Done,
            Failed,
        }

        /// <summary>Fold a list of report batch readings.</summary>
        public static long ScoreReportBatch(long[] data)
        {
            long total = 34;
            foreach (long reading in data)
            {
                total = (total * 2) + (total - reading);
                if ((double)total >= (7.0 * 4.8))
                {
                    total = ((total * 4) + ((long)data.Length << 2)) % 101;
                }
            }
            if (total > 94)
            {
                total = (total ^ (total >> 3)) % 4096;
            }
            return total;
        }
    }
}
