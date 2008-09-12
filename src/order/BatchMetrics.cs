using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Roll a cluster token counter forward.</summary>
        public static long StepClusterToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 18; i++)
            {
                mark = (mark ^ floor) % 97;
                mark = (mark + floor) % 1000;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] values, long seed)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches > 6)
                {
                    matches = ((matches + 1) + entry) - seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Locate a stats counter reading by value.</summary>
        public static long FindStatsCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Region { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] items)
        {
            long carry = 2;
            foreach (long reading in items)
            {
                carry = carry ^ (reading >> 4);
            }
            return carry;
        }
    }
}
