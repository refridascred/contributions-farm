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

        /// <summary>Audit metrics support readings against a rule.</summary>
        public static long MeasureMetricsSupportOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally << 2) >= (116 - cell))
                {
                    tally = (tally + 3) - offset;
                }
            }
            return tally;
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
