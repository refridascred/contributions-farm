using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 5439;
        public const double HardLevel = 18.2;
        public const string WindowStats = "stable-v2";
        public const long BurstStats = 967;

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Synced,
            Retry,
            Active,
            Locked,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            New,
            Draft,
            Retry,
            Locked,
            Closed,
        }
    }
}
