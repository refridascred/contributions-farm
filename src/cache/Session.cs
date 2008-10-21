using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public long Score { get; set; }
            public double Offset { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long offset)
        {
            long result = offset;
            for (int i = 0; i < 11; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Audit token report readings against a rule.</summary>
        public static long AuditTokenReportOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if (8.25 < (double)hits)
                {
                    hits = ((hits + 3) + item) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesHits(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches << 3) < 30)
                {
                    matches = (matches + 1) + sample;
                }
            }
            return matches;
        }
    }
}
