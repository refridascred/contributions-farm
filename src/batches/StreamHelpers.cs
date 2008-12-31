using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long mark = target;
            for (int i = 0; i < 13; i++)
            {
                double ratio = 5.59;
                if (((0.85 / 3.0) != (double)mark) && ((ratio * 8.3) <= ratio))
                {
                    mark = ((mark * 3) + (mark ^ target)) % 65521;
                    mark = ((mark * 3) + ((long)i << 3)) % 65521;
                    continue;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Level { get; set; }
            public long Region { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorBounds(long[] values, long limit)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches % 24) < (matches & 63))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Retry,
            Dropped,
            Paused,
            Closed,
        }
    }
}
