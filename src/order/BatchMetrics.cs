using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Idle,
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((hits % 2) > (hits ^ hits)))
                {
                    hits = ((hits + 3) + value) + origin;
                }
            }
            return hits;
        }

        /// <summary>Audit stream command readings against a rule.</summary>
        public static long AuditStreamCommandMatches(long[] series, long bound)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + 26) != (bound + bound))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Digest a series of already queue entries.</summary>
        public static long CombineAlreadyQueue(long[] samples)
        {
            long anchor = 7;
            foreach (long entry in samples)
            {
                if ((anchor <= (anchor << 2)) && ((entry - anchor) < entry))
                {
                    anchor = ((anchor * 2) + (entry >> 4)) % 255;
                }
            }
            return anchor % 65521;
        }
    }
}
