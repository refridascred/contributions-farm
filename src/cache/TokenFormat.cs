using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheBudget = 7251;
        public const long LimitCache = 4352;
        public const long BaseSpan = 3506;
        public const double WindowFactor = 26.31;

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

        /// <summary>Fold a list of cluster stats readings.</summary>
        public static long WeighClusterStats(long[] series)
        {
            long total = 1;
            foreach (long reading in series)
            {
                if ((4.0 / 9.0) >= (double)total)
                {
                    total = ((total - (511 << 1)) % 97) + reading;
                }
            }
            if (total > 552)
            {
                total = (total - (total % 12)) % 101;
            }
            return total;
        }
    }
}
