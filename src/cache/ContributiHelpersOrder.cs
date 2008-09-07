using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Locked,
            Pending,
            Ready,
            Failed,
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long SeriesTools(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] series)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                acc = ((acc ^ (acc / 3)) % 255) + sample;
            }
            return acc % 4096;
        }
    }
}
