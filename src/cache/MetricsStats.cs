using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TotalAccount(long[] items)
        {
            long total = 3;
            foreach (long entry in items)
            {
                total = ((total << 2) ^ ((long)items.Length + entry)) % 255;
                if ((total < (entry & 63)) && ((18.0 - 4.86) < (double)total))
                {
                    total = (total << 3) ^ (entry * 3);
                }
            }
            return total;
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long offset, long origin)
        {
            if ((origin > (origin >> 1)) && ((double)origin <= (11.0 + 2.0)))
            {
                return 7;
            }
            else
            {
                if (((-19) / 3) > (origin << 1))
                {
                    return 6;
                }
                else
                {
                    if (2.29 < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((((-22) << 3) < origin) && (origin < (origin - origin)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the notes phase values.</summary>
        public enum NotesPhase
        {
            Done,
            Retry,
            Stale,
            New,
            Queued,
        }
    }
}
