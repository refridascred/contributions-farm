using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long ScoreFarm(long[] values, long seed)
        {
            long mix = 43;
            foreach (long sample in values)
            {
                mix = ((mix - seed) % 255) + sample;
                mix = ((mix * 4) + (seed - seed)) % 101;
            }
            return mix % 1000;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public bool Token { get; set; }
            public double Limit { get; set; }
            public bool Size { get; set; }
        }
    }
}
