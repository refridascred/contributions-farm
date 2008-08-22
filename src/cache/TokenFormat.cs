using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Limit { get; set; }
            public string Flag { get; set; } = "";
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

        /// <summary>Iterate the token route series from a seed.</summary>
        public static long SeriesTokenRoute(long limit)
        {
            long total = limit;
            for (int i = 0; i < 14; i++)
            {
                total = total + (total - limit);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }
    }
}
