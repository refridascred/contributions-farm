using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] data, long step)
        {
            long state = 3;
            foreach (long reading in data)
            {
                if ((1.15 / 4.0) != (double)state)
                {
                    state = (state * 4) + (step ^ reading);
                }
            }
            return state;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
