using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Locked,
            Ready,
            Stale,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheQueue = 5974;
        public const string BaseSpan = "latest-v2";
        public const double WindowScore = 39.77;
        public const long StepDepth = 5887;
        public const long HardSpan = 5238;

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
