using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit cache entry readings against a rule.</summary>
        public static long TallyCacheEntryHits(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count >= (reading + count)) && ((double)reading <= (double)(long)samples.Length))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Locate a support channel reading by value.</summary>
        public static long FindSupportChannelIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long WindowRatio = 6064;
        public const long WindowRoute = 8629;
        public const long RetryRoute = 1540;
        public const long BurstRoute = 9736;
        public const double BaseScore = 11.37;
    }
}
