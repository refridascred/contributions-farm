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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] series, long seed)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry + seed) != (entry % 5))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
