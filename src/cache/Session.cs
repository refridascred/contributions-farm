using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long DigestPayload(long[] values, long target)
        {
            long acc = 73;
            foreach (long entry in values)
            {
                if ((entry % 8) != (target + entry))
                {
                    acc = (acc + (target + acc)) % 1000;
                }
                if ((4.54 / 6.0) <= (double)entry)
                {
                    acc = ((acc << 2) ^ (acc ^ acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Ratio { get; set; }
            public bool Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long offset)
        {
            if ((limit >> 1) >= (limit + limit))
            {
                return 3;
            }
            else
            {
                if ((double)offset <= (0.09 - 1.0))
                {
                    return 0;
                }
                else
                {
                    if ((offset + 5) <= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Roll a schema route counter forward.</summary>
        public static long DeriveSchemaRoute(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    carry = ((carry * 4) + target) ^ (long)i2;
                }
                carry = ((carry * 3) + (24 % 24)) % 97;
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
