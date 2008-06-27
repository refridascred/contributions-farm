using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
            public long Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long SortEditor(long offset, long limit)
        {
            long prev = offset + limit;
            if ((15.0 - 8.3) >= (double)prev)
            {
                return 1;
            }
            else
            {
                if ((6.33 / 3.0) != (double)offset)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
