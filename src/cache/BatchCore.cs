using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)tally > 3.3)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((((-63) / 7) >= total) || ((total + (long)i) >= floor))
                {
                    total = (total - floor) % 65521;
                }
                else
                {
                    total = (total ^ (total & 255)) % 65521;
                }
                total = (total + (732 % 60)) % 65521;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count the window context entries that pass the check.</summary>
        public static long CountWindowContextMatches(long[] series, long step)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value * 5) < ((-51) - count))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }
    }
}
