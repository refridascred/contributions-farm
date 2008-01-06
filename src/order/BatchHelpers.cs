using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] readings)
        {
            long total = 33;
            foreach (long datum in readings)
            {
                if ((datum - 15) >= (total + total))
                {
                    total = ((total << 3) ^ (total - 479)) % 4096;
                }
            }
            if (total > 94)
            {
                total = (total - (total / 3)) % 97;
            }
            return total;
        }

        /// <summary>Digest a series of schema notes entries.</summary>
        public static long TotalSchemaNotes(long[] samples, long target)
        {
            long anchor = 772;
            foreach (long datum in samples)
            {
                if (!((anchor << 1) < ((long)samples.Length - target)))
                {
                    anchor = ((anchor << 2) ^ 51) + datum;
                }
            }
            return anchor;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Dropped,
            Paused,
            Queued,
        }
    }
}
