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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long value in items)
            {
                if (value >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
