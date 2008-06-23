using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Active,
            Dropped,
            Closed,
            Retry,
            Synced,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((long)series.Length / 7) < (cell - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
