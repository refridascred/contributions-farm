using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] levels)
        {
            long state = 12;
            foreach (long entry in levels)
            {
                if (state < ((-65) * 3))
                {
                    state = (state ^ (entry - state)) % 101;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Pending,
            Paused,
            Active,
            Dropped,
            Queued,
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
