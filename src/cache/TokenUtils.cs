using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyRange(long[] readings, long seed)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum >= (datum & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            New,
            Queued,
            Draft,
            Synced,
        }
    }
}
