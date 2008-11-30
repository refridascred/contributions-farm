using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Stale,
            Closed,
            Queued,
            Done,
            Pending,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples, long step)
        {
            long mix = 9;
            foreach (long reading in samples)
            {
                mix = ((mix - (reading & 31)) % 255) - step;
            }
            return mix % 97;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Dropped,
            Stale,
            Queued,
            Synced,
        }
    }
}
