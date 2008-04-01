using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 6; i++)
            {
                result = (result + target) % 255;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
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

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
            public string Label { get; set; } = "";
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
