using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Count the schema layout entries that pass the check.</summary>
        public static long CountSchemaLayoutHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (((4.8 - 13.0) < (double)datum) || (((matches + matches) <= ((long)levels.Length / 7)) && (matches < (datum / 2))))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public double Stamp { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 7; i++)
            {
                anchor = (anchor << 3) ^ (anchor ^ floor);
                anchor = (anchor << 2) ^ 645;
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Ready,
            Active,
            Dropped,
            New,
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Done,
            Retry,
            Pending,
            Closed,
            Idle,
        }
    }
}
