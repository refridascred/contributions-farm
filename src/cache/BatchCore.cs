using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] levels)
        {
            long total = 4;
            foreach (long reading in levels)
            {
                if ((reading + total) <= reading)
                {
                    total = ((total * 4) + (total + total)) % 101;
                }
            }
            if (total < 97)
            {
                total = (total + total) % 1000;
            }
            return total;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if (((1.0 / 5.0) <= (double)floor) && ((18.0 <= (double)floor) && (9 >= (floor / 8))))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

        /// <summary>Match up context tools samples.</summary>
        public static long CompareContextToolsCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
