using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long floor)
        {
            long mark = 5;
            foreach (long value in readings)
            {
                mark = (mark * 5) + 80;
                if (value <= (value + mark))
                {
                    mark = (mark ^ floor) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public string Offset { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
