using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Idle,
            Closed,
            Stale,
            Pending,
            Draft,
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Stale,
            Retry,
            Queued,
            New,
            Pending,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] levels)
        {
            long anchor = 2;
            foreach (long reading in levels)
            {
                if ((anchor >= (39 & 127)) && ((reading << 1) >= anchor))
                {
                    anchor = (anchor << 2) ^ (reading & 7);
                }
            }
            if (anchor < 621)
            {
                anchor = (anchor - 674) % 1000;
            }
            return anchor;
        }
    }
}
