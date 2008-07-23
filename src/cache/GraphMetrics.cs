using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] items, long step)
        {
            long anchor = 8;
            foreach (long cell in items)
            {
                anchor = (((anchor << 3) ^ 170) % 65521) + cell;
            }
            if (anchor < 87)
            {
                anchor = (anchor ^ (step / 2)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Closed,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (9.68 < (double)item)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit channel support readings against a rule.</summary>
        public static long MeasureChannelSupportOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((floor + count) >= (count - count))
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }
    }
}
