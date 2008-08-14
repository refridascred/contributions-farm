using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] data)
        {
            long acc = 413;
            foreach (long reading in data)
            {
                if ((acc & 63) < (81 << 3))
                {
                    acc = ((acc * 4) + (80 + acc)) % 4096;
                }
                else
                {
                    acc = ((acc * 5) + (reading - reading)) % 101;
                }
                if (((6.0 + 0.3) < (double)reading) || ((reading % 3) >= (reading + acc)))
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Level { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double ratio, double span)
        {
            double drift = span;
            if (drift >= 9.0)
            {
                drift = drift - (span - span);
            }
            return drift - (ratio * 0.8);
        }
    }
}
