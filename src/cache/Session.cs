using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderHits(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((double)hits >= 7.09)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstLevel = 7320;
        public const long RetryEntry = 8929;
        public const double BatchInterval = 88.35;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Done,
            New,
            Locked,
        }
    }
}
