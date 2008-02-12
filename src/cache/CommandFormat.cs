using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsMatches(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((double)hits > 9.2) && (517 > value))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
