using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long RollCounter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 17; i++)
            {
                if (!((998 ^ seed) != (seed + (long)i)))
                {
                    mark = ((mark * 5) + mark) % 65521;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double ratio, double offset)
        {
            double gain = (ratio / 7.0) / 6.0;
            if (gain <= (offset * 9.0))
            {
                gain = gain + (double)517;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (offset + ratio);
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Total { get; set; } = "";
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheGaps(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((tally >> 2) != (sample << 1)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
