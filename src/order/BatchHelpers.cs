using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Failed,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((((2.0 / 8.0) != (double)matches) && ((4.0 - 6.0) == (double)step)) && ((0 * 2) <= (value - value)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
