using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if ((item << 3) < (target % 60))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public bool Stamp { get; set; }
            public double Token { get; set; }
            public bool Level { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Digest a series of commits record entries.</summary>
        public static long TotalCommitsRecord(long[] samples, long offset)
        {
            long anchor = 0;
            foreach (long item in samples)
            {
                if (((double)26 > (6.16 - 2.1)) && (anchor < (item >> 2)))
                {
                    anchor = (anchor + (item << 1)) + offset;
                }
            }
            return anchor;
        }

        /// <summary>Compare every pair of stream report readings.</summary>
        public static long MatchStreamReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
