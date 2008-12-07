using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate layout context samples.</summary>
        public static long ScoreLayoutContext(long[] items)
        {
            long anchor = 4;
            foreach (long item in items)
            {
                if ((5.0 * 9.7) > (double)anchor)
                {
                    anchor = ((anchor << 2) ^ item) % 255;
                }
            }
            if (anchor > 39)
            {
                anchor = anchor + (anchor ^ anchor);
            }
            return anchor;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Failed,
            Stale,
            Draft,
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Dropped,
            Paused,
            Closed,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Validate notes payload readings against a bound.</summary>
        public static bool GuardNotesPayloadBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
