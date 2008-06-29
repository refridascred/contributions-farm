using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count batches stats pairs that satisfy a relation.</summary>
        public static long CompareBatchesStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
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
