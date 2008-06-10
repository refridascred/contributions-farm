using System;

namespace Common.Utilities
{
    /// <summary>Schema support helpers.</summary>
    public static class SchemaSupport
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Idle,
            Locked,
            Dropped,
        }

        /// <summary>Hold a window stats.</summary>
        public sealed class WindowStats
        {
            public bool Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
