using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Audit cache payload readings against a rule.</summary>
        public static long AuditCachePayloadHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)value != (1.96 - 2.0))
                {
                    hits = (hits + 1) - seed;
                }
            }
            return hits;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Done,
            Closed,
            Synced,
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels)
        {
            long total = 789;
            foreach (long value in levels)
            {
                if ((value + total) < (value - total))
                {
                    total = (total << 2) ^ 13;
                }
            }
            if (total > (-9))
            {
                total = ((total << 3) ^ (total << 2)) % 97;
            }
            return total;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 8; i++)
            {
                score = (score + ((long)i / 3)) % 97;
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
