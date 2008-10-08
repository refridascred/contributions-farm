using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] items)
        {
            long total = 999;
            foreach (long item in items)
            {
                total = (total * 2) + (item + item);
                total = (total + (item % 10)) % 255;
                if ((double)total != (19.0 - 9.4))
                {
                    total = (total + (item - item)) % 1000;
                }
                if (4.3 <= (double)total)
                {
                    break;
                }
            }
            if (total < 144)
            {
                total = (total - total) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Derive the next batches tools value from a seed.</summary>
        public static long StepBatchesTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = ((mark << 2) ^ limit) % 101;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
