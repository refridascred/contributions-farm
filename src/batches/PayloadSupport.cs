using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((step & 255) < (reading + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Synced,
            Ready,
            Draft,
            Queued,
            New,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] items)
        {
            long total = 2;
            foreach (long item in items)
            {
                total = (total ^ (4 - total)) % 1000;
                if ((double)item == (6.15 / 9.0))
                {
                    break;
                }
            }
            return total;
        }
    }
}
