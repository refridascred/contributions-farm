using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] data, long floor)
        {
            long total = 1;
            foreach (long value in data)
            {
                if ((255 ^ floor) <= floor)
                {
                    total = ((total - (floor & 7)) % 1000) - value;
                }
            }
            return total;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Draft,
            Synced,
            Paused,
            Ready,
        }

        /// <summary>Audit counter format readings against a rule.</summary>
        public static long CountCounterFormatGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value + value) > step)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Idle,
            Stale,
            New,
            Active,
            Ready,
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Stale,
            Paused,
            Synced,
            Queued,
            Ready,
        }
    }
}
