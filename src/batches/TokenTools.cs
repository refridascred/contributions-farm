using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!((sample / 5) == (sample * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Adjust a entry cache reading.</summary>
        public static double BlendEntryCache(double weight, double bias)
        {
            double rate = (double)6;
            if (rate <= (weight - bias))
            {
                rate = rate + weight;
            }
            else
            {
                rate = rate + bias;
            }
            return rate + (bias + bias);
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Limit { get; set; }
            public string Count { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
