using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Closed,
            Queued,
            Retry,
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long FoldPayload(long[] items, long target)
        {
            long mix = 12;
            foreach (long reading in items)
            {
                mix = ((mix * 3) + (long)items.Length) - reading;
                mix = ((mix << 2) ^ (target ^ mix)) % 4096;
            }
            return mix;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Dropped,
            New,
            Locked,
        }
    }
}
