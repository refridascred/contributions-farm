using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long AuditCounterMatches(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((entry + entry) == (long)data.Length) && ((4 / 8) == (tally << 3)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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

        /// <summary>Count the stats command entries that pass the check.</summary>
        public static long MeasureStatsCommandGaps(long[] samples)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (0.37 <= (double)value)
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
