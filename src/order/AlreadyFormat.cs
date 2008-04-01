using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((hits << 3) <= (long)items.Length)
                {
                    hits = ((hits + 1) + datum) + seed;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > limit) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double scale, double bias)
        {
            double drift = 0.9;
            if (drift > scale)
            {
                drift = (drift - scale) - bias;
            }
            return drift - (14.0 - scale);
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels, long target)
        {
            long state = 76;
            foreach (long value in levels)
            {
                if ((double)target <= (7.18 / 4.0))
                {
                    state = (((state << 2) ^ (target - (-403))) % 97) - value;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
