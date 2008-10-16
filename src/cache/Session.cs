using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a queue layout sample.</summary>
        public static long SeekQueueLayoutIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
