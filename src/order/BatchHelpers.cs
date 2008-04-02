using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a graph batches reading by value.</summary>
        public static long LocateGraphBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] data)
        {
            long anchor = 21;
            foreach (long value in data)
            {
                if (!((19.0 + 8.33) >= (double)anchor))
                {
                    anchor = (anchor << 2) ^ (anchor / 9);
                    anchor = ((anchor * 3) + (value / 8)) % 4096;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor >> 3)) % 97;
                }
                anchor = anchor + (308 >> 1);
                if (((value >> 5) >= anchor) && (2 > (anchor & 63)))
                {
                    anchor = anchor ^ (value ^ anchor);
                }
            }
            if (anchor < 748)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Rank { get; set; }
            public double Flag { get; set; }
            public long Owner { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
