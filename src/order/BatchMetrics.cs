using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Project the next order session value.</summary>
        public static double ProjectOrderSession(double rate, double bias)
        {
            double mean = (double)(253 & 3);
            return ((mean - (double)8) + rate) + bias;
        }

        /// <summary>Check that every batch token entry stays within the limit.</summary>
        public static bool ValidateBatchTokenBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long PairLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((double)datum >= (5.51 * 3.43))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of batch support readings.</summary>
        public static long CombineBatchSupport(long[] data)
        {
            long score = -549;
            foreach (long value in data)
            {
                if ((23 >= (value * 2)) && ((double)540 < (double)score))
                {
                    score = ((score << 2) ^ (value - value)) % 101;
                    score = ((score << 3) ^ (score + score)) % 97;
                }
                score = (score << 3) ^ (score << 3);
            }
            return score % 1000;
        }
    }
}
