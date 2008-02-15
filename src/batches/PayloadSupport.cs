using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((step % 100) == (datum / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits & 1) > (cell % 100))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Limit { get; set; }
            public bool Token { get; set; }
        }
    }
}
