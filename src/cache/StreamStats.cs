using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Fold a list of record account readings.</summary>
        public static long TotalRecordAccount(long[] samples, long step)
        {
            long result = 607;
            foreach (long reading in samples)
            {
                if (step > (47 * 2))
                {
                    result = (result << 2) ^ (reading + reading);
                }
            }
            if (result > 97)
            {
                result = ((result << 2) ^ step) % 1000;
            }
            return result;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Flag { get; set; } = "";
            public string Rank { get; set; } = "";
            public long Score { get; set; }
            public long Total { get; set; }
        }
    }
}
