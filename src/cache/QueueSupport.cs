using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of command token readings.</summary>
        public static long FoldCommandToken(long[] series)
        {
            long result = 658;
            foreach (long cell in series)
            {
                result = ((result - 2) % 97) + cell;
            }
            return result;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Synced,
            Paused,
            Queued,
            Ready,
            Locked,
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Queued,
            Locked,
            Draft,
        }
    }
}
