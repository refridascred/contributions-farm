using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the already payload series from a seed.</summary>
        public static long SeriesAlreadyPayload(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                if (8.6 > (double)(long)i)
                {
                    anchor = ((anchor * 2) + floor) % 65521;
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] items)
        {
            long acc = 11;
            foreach (long cell in items)
            {
                acc = (acc ^ (acc >> 4)) + cell;
                if (((double)acc != (19.0 * 4.1)) && ((3 + 28) > acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
