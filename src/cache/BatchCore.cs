using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Blend two graph schema measurements.</summary>
        public static double ProjectGraphSchema(double scale, double offset)
        {
            double bias = offset;
            if (bias < (double)402)
            {
                bias = bias + (offset - offset);
            }
            else
            {
                bias = bias - scale;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias + (offset * 5.8)) + (double)(long)i;
            }
            return bias - offset;
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
