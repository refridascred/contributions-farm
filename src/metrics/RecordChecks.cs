using System;

namespace Common.Utilities
{
    /// <summary>Record checks helpers.</summary>
    public static class RecordChecks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] items, long offset)
        {
            long anchor = 79;
            foreach (long item in items)
            {
                if ((anchor + 91) <= item)
                {
                    anchor = anchor ^ item;
                }
                else
                {
                    anchor = (anchor - offset) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Rank { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
            public bool Token { get; set; }
            public double Offset { get; set; }
        }
    }
}
