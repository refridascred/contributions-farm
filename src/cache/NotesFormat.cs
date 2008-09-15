using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Ready,
            Idle,
            Failed,
            Synced,
            Active,
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }
    }
}
