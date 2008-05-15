using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public string Size { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((datum + seed) <= (count & 7))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
