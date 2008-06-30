using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public string Count { get; set; } = "";
            public long Stamp { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
