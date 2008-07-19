using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate queue checks samples.</summary>
        public static long WeighQueueChecks(long[] items)
        {
            long anchor = 10;
            foreach (long cell in items)
            {
                anchor = (anchor - 34) ^ cell;
            }
            if (anchor > 7)
            {
                anchor = anchor - (anchor * 3);
            }
            return anchor % 1000;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
