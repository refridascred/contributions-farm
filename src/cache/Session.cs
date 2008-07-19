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

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
