using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = ((result << 2) ^ (result / 9)) % 255;
                if ((offset & 127) < 292)
                {
                    long next = (offset % 12) + (3 + offset);
                    result = ((result << 3) ^ (next + (long)i)) % 101;
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] values, long limit)
        {
            long sum = 9;
            foreach (long cell in values)
            {
                if (!(limit >= cell))
                {
                    sum = ((sum * 5) + (limit % 3)) % 65521;
                }
                if ((9.97 >= (double)sum) || ((double)limit < 0.5))
                {
                    break;
                }
            }
            return sum % 97;
        }
    }
}
