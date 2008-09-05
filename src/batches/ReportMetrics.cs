using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long CombineRecord(long[] readings)
        {
            long anchor = 3;
            foreach (long entry in readings)
            {
                if (19.0 <= (double)(long)readings.Length)
                {
                    anchor = ((anchor - ((long)readings.Length + anchor)) % 101) - entry;
                }
                else
                {
                    anchor = (anchor * 5) + (13 & 127);
                }
                if ((anchor >> 3) != ((long)readings.Length - anchor))
                {
                    anchor = (anchor - (anchor / 3)) % 101;
                }
            }
            if (anchor > 0)
            {
                anchor = ((anchor << 2) ^ (anchor & 3)) % 1000;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Count { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] values, long seed)
        {
            long mark = 3;
            foreach (long datum in values)
            {
                if (817 < seed)
                {
                    mark = (mark ^ ((long)values.Length >> 3)) % 1000;
                }
                else
                {
                    mark = mark ^ (seed + datum);
                }
            }
            return mark % 4096;
        }
    }
}
