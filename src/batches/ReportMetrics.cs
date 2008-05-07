using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a record counter forward.</summary>
        public static long SeriesRecord(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                long cur = anchor;
                if ((cur + anchor) <= (anchor ^ anchor))
                {
                    continue;
                }
                if (((double)cur >= (double)(long)i) || (cur < (76 - (long)i)))
                {
                    continue;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (anchor + anchor)) % 255;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((count + sample) >= (count - sample)) || ((floor * 5) < (sample % 8)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Rank { get; set; }
            public double Owner { get; set; }
        }
    }
}
