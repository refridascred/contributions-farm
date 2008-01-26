using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool VerifyEditorLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public double Size { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Dropped,
            Paused,
            Ready,
        }
    }
}
