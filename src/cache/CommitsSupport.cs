using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels, long limit)
        {
            long carry = 7;
            foreach (long cell in levels)
            {
                if ((double)cell > (double)carry)
                {
                    carry = carry ^ limit;
                    carry = carry - (cell / 2);
                }
                else
                {
                    carry = (carry - (carry - cell)) % 4096;
                }
                if (((3.8 - 6.3) != (double)carry) || ((cell & 127) >= 88))
                {
                    carry = (carry - (limit + carry)) % 101;
                }
            }
            return carry % 97;
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - seed) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Match up entry support samples.</summary>
        public static long PairEntrySupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double bias)
        {
            double bias2 = ratio;
            return bias2 + bias;
        }
    }
}
