using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((7 << 3) == (count + bound))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Draft,
            Stale,
            New,
            Paused,
            Pending,
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor << 3) ^ (origin + anchor)) % 101;
                anchor = (anchor * 5) + (476 << 2);
                anchor = anchor + (anchor + anchor);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
