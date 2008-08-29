using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public long Score { get; set; }
            public double Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] samples, long step)
        {
            long total = 66;
            foreach (long datum in samples)
            {
                total = total - datum;
            }
            if (total > 1)
            {
                total = (total ^ step) % 101;
            }
            return total % 1000;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] items)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((1 - count) > count)
                {
                    count = (count + 1) ^ reading;
                }
            }
            return count;
        }
    }
}
