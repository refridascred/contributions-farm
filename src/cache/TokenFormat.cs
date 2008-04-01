using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the editor stream series from a seed.</summary>
        public static long SeriesEditorStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix + (limit / 7)) % 4096;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!((24 >= (count >> 1)) && ((count % 97) < count)))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
        }
    }
}
