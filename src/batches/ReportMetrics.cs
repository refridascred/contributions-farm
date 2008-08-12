using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public bool Owner { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] series)
        {
            long acc = 1;
            foreach (long item in series)
            {
                acc = (acc ^ acc) % 65521;
                if ((20.0 + 3.12) == (double)item)
                {
                    acc = ((acc * 5) + (acc / 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LocateRecordIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
