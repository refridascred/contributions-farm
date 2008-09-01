using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Locked,
            Stale,
            Retry,
            Synced,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long AuditFormatHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 4) == (count + cell))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] samples)
        {
            long anchor = 72;
            foreach (long reading in samples)
            {
                anchor = ((anchor + ((long)samples.Length * 3)) % 97) + reading;
            }
            if (anchor > 7)
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }
    }
}
