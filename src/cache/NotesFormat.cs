using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftEditor = 1413;
        public const long DefaultFactor = 1849;
        public const long BatchBudget = 9817;
        public const double CacheEditor = 35.75;

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            New,
            Ready,
            Dropped,
            Pending,
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (6.9 <= (double)tally)
                {
                    tally = (tally + 3) ^ cell;
                }
            }
            return tally;
        }
    }
}
