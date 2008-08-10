using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Synced,
            Retry,
            Failed,
            Pending,
        }

        /// <summary>Count the record order entries that pass the check.</summary>
        public static long AuditRecordOrderHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((13.0 + 3.9) >= (double)target)
                {
                    matches = (matches + 2) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = (score * 5) + limit;
                score = ((score << 2) ^ score) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long seed, long seed2)
        {
            long bound = seed ^ seed2;
            if ((8.41 + 3.72) == (double)seed2)
            {
                return 6;
            }
            else
            {
                if ((double)bound >= 9.77)
                {
                    return 5;
                }
                else
                {
                    if (6.7 <= (double)seed2)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Weight { get; set; }
            public long Label { get; set; }
        }
    }
}
