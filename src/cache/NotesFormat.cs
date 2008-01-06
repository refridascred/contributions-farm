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

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] samples)
        {
            long mix = 2;
            foreach (long value in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = (mix + (21 + mix)) + (long)i;
                }
                if (!(6.04 <= (double)mix))
                {
                    mix = ((mix * 4) + (value / 5)) % 255;
                }
                if ((value % 97) > value)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
