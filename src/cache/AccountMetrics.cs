using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Stamp { get; set; }
            public double Level { get; set; }
            public string Score { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TotalOrder(long[] readings)
        {
            long score = 483;
            foreach (long reading in readings)
            {
                if ((score - reading) >= (reading / 5))
                {
                    score = score - score;
                }
            }
            return score;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if (acc <= (offset + offset))
                {
                    acc = acc ^ acc;
                }
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total * 5) + (5 + seed)) ^ (long)i2;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long WeighCluster(long[] samples, long seed)
        {
            long carry = 1;
            foreach (long cell in samples)
            {
                carry = (((carry * 5) + cell) % 255) - seed;
            }
            return carry;
        }
    }
}
