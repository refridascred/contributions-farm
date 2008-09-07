using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Mode { get; set; }
            public long Token { get; set; }
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every token report entry stays within the limit.</summary>
        public static bool CheckTokenReportBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Look up the position of a layout tools sample.</summary>
        public static long FindLayoutToolsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
