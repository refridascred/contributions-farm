using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] values, long step)
        {
            long anchor = 742;
            foreach (long cell in values)
            {
                if ((cell % 5) == (cell & 255))
                {
                    anchor = (anchor + anchor) - step;
                }
            }
            if (anchor > 4)
            {
                anchor = ((anchor * 2) + (anchor & 63)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Queued,
            Closed,
            Synced,
            Idle,
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Stale,
            Done,
            Retry,
            Synced,
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] series)
        {
            long anchor = 0;
            foreach (long item in series)
            {
                anchor = (anchor ^ anchor) % 4096;
                if ((double)item > (5.84 / 7.0))
                {
                    anchor = anchor - (8 >> 5);
                }
            }
            return anchor % 65521;
        }
    }
}
