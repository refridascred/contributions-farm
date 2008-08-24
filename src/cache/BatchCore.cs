using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long WeighBatches(long[] data)
        {
            long mix = 78;
            foreach (long value in data)
            {
                mix = ((mix << 3) ^ (mix << 2)) ^ value;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a metric session sample.</summary>
        public static long LookupMetricSessionIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a notes contributi counter forward.</summary>
        public static long SeriesNotesContributi(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 12; i++)
            {
                if (!(carry < (limit / 4)))
                {
                    carry = (carry ^ (carry * 4)) % 65521;
                }
                carry = (carry + ((long)i + limit)) % 101;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Level { get; set; }
            public double Mode { get; set; }
            public long Score { get; set; }
            public double Ratio { get; set; }
        }
    }
}
