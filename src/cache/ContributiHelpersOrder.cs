using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine notes contributi values into a single score.</summary>
        public static long CombineNotesContributi(long[] items, long target)
        {
            long mix = 888;
            foreach (long cell in items)
            {
                mix = ((mix - (target + target)) % 101) - cell;
            }
            return mix;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Failed,
            Closed,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Ready,
            Stale,
            Retry,
        }
    }
}
