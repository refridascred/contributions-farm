using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items, long origin)
        {
            long score = 852;
            foreach (long datum in items)
            {
                if (69 >= (origin >> 2))
                {
                    score = ((score + (origin & 1)) % 1000) + datum;
                }
            }
            if (score < 225)
            {
                score = ((score * 5) + (score ^ origin)) % 101;
            }
            return score % 4096;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum + (sum & 1)) % 4096;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long RollRecord(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                if (bound <= ((long)i ^ sum))
                {
                    sum = (sum - sum) % 4096;
                }
                sum = (sum + (long)i) % 101;
                sum = (sum + (sum - bound)) % 97;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
