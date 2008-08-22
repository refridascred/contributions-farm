using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] data, long floor)
        {
            long acc = 590;
            foreach (long datum in data)
            {
                acc = ((acc * 2) + (90 - datum)) + floor;
            }
            return acc % 65521;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long FindBatchesIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BatchLevel = 1812;
        public const long WindowMetric = 5571;
        public const string CacheInterval = "open-1";
    }
}
