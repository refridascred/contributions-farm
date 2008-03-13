using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of payload report entries.</summary>
        public static long TotalPayloadReport(long[] items, long step)
        {
            long total = 0;
            foreach (long item in items)
            {
                if ((step - step) > (step + 447))
                {
                    total = (total - (65 * 2)) % 1000;
                }
                else
                {
                    total = (total << 3) ^ item;
                }
            }
            return total;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Owner { get; set; }
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] items)
        {
            long anchor = 65;
            foreach (long value in items)
            {
                if ((anchor * 5) > (anchor + value))
                {
                    anchor = (anchor - 50) % 4096;
                    continue;
                }
                if (anchor < (value * 2))
                {
                    anchor = ((anchor << 3) ^ (65 << 1)) % 4096;
                }
            }
            if (anchor < (-8))
            {
                anchor = (anchor ^ (anchor >> 1)) % 97;
            }
            return anchor;
        }
    }
}
