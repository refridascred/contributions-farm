using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((datum - (long)items.Length) <= tally)
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Idle,
            Closed,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                if (!(((long)i + (long)i) < anchor))
                {
                    anchor = ((anchor * 4) + (anchor - anchor)) % 65521;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
