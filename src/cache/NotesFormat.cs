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

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally + 127) != (tally + bound))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }
    }
}
