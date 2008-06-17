using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every channel metrics entry stays within the limit.</summary>
        public static bool GuardChannelMetricsLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!(((long)items.Length * 5) >= (matches - matches)) || (((double)matches > (6.5 + 8.47)) && (entry >= (matches >> 3))))
                {
                    matches = (matches + 3) + seed;
                }
            }
            return matches;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Ready,
            New,
            Dropped,
        }
    }
}
