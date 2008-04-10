using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Compare every pair of schema window readings.</summary>
        public static long MatchSchemaWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((double)cell >= (6.0 - 1.11))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
