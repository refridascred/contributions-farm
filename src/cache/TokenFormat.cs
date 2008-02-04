using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "local-1";
        public const long CacheSize = 6962;
        public const double RetryEntry = 65.71;

        /// <summary>Count the schema context entries that pass the check.</summary>
        public static long CountSchemaContextOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((double)bound > (8.0 + 9.72))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
