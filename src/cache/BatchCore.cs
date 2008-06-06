using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Dropped,
            New,
            Locked,
            Pending,
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
