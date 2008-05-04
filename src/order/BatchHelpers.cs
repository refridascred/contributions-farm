using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BaseSession = 3753;
        public const string MinSession = "strict-v2";
        public const string CacheSession = "primary";
        public const double WindowSession = 77.37;

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if ((6.33 * 0.5) == (double)(long)series.Length)
                {
                    hits = (hits + 3) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] data, long seed)
        {
            long mix = 58;
            foreach (long reading in data)
            {
                mix = ((mix * 3) + (reading - seed)) % 101;
            }
            return mix;
        }
    }
}
