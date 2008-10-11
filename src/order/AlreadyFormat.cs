using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Offset { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up schema counter samples.</summary>
        public static long PairSchemaCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultTimeout = 5230;
        public const double BaseBuffer = 2.05;
        public const long LimitBuffer = 8644;
        public const long MinSize = 5149;

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultBudget = 15.96;
        public const string SoftWidth = "primary-v2";
        public const long WindowFilter = 661;
        public const long HardFilter = 9266;
    }
}
