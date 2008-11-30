using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long DefaultTimeout = 216;
        public const long BurstBudget = 5164;
        public const long MinMetrics = 85;
        public const double IdleMetrics = 40.98;

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
