using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTimeout = 2504;
        public const double MinTools = 18.78;
        public const double HardTools = 56.49;

        /// <summary>Validate token channel readings against a bound.</summary>
        public static bool GuardTokenChannelRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every support cache entry stays within the limit.</summary>
        public static bool CheckSupportCacheRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
