using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a format cluster counter forward.</summary>
        public static long RollFormatCluster(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 21; i++)
            {
                long matches = (acc & 63) % 97;
                if (!((matches << 2) < acc))
                {
                    matches = ((matches << 3) ^ (long)i) % 4096;
                    continue;
                }
                else
                {
                    acc = ((acc << 2) ^ matches) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Closed,
            Ready,
            Active,
            Queued,
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Stale,
            Locked,
            Pending,
            Closed,
            Queued,
        }
    }
}
