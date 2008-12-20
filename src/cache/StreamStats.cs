using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)datum > 7.97)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Synced,
            New,
            Ready,
            Failed,
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Failed,
            Stale,
            Idle,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Locked,
            Dropped,
        }
    }
}
