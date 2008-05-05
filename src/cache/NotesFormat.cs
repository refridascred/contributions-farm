using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate buffer queue readings against a bound.</summary>
        public static bool GuardBufferQueueRange(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MinChannel = 2647;
        public const long BurstFactor = 2726;
        public const long BurstChannel = 6917;
        public const double BaseChannel = 54.04;
        public const long CacheChannel = 3083;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinSize = 6304;
        public const long HardDepth = 3047;
        public const long LimitInterval = 8954;
        public const long CacheWidth = 1576;
        public const long WindowTimeout = 9882;
    }
}
