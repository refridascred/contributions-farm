using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
