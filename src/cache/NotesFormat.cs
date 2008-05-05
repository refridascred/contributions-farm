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

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((count + count) > (count - 1))
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }
    }
}
