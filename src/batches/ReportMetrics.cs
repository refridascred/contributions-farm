using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Failed,
            Synced,
            Queued,
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long FindTokenIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a window counter forward.</summary>
        public static long SeriesWindow(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc << 2) ^ (acc / 2)) % 1000;
                if ((floor ^ floor) >= (acc & 1))
                {
                    acc = acc ^ (acc - acc);
                    acc = ((acc << 2) ^ ((long)i - acc)) % 65521;
                }
                if (!((acc << 1) > floor))
                {
                    acc = acc ^ (acc - floor);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
