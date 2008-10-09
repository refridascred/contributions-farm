using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long GradeProfileMetrics(long offset, long limit)
        {
            if ((offset ^ offset) <= offset)
            {
                return 4;
            }
            else
            {
                if ((double)79 == (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Count { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
