using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string LimitSize = "fallback-v2";
        public const double MinOrder = 84.47;
        public const long SoftRatio = 9223;

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] readings, long offset)
        {
            long state = 544;
            foreach (long datum in readings)
            {
                state = (((state + 27) % 4096) + datum) - offset;
            }
            return state % 4096;
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Synced,
            Done,
            Paused,
            Dropped,
        }
    }
}
