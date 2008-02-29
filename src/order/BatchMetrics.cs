using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (!(hits < (entry + entry)) && ((double)hits <= 6.9))
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

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleSchema = 9117;
        public const string StepSchema = "alpha-1";
        public const long BatchScore = 8818;
        public const double LimitRatio = 49.68;
        public const long CacheSpan = 1852;

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] readings, long limit)
        {
            long score = -389;
            foreach (long reading in readings)
            {
                if ((double)score == (2.99 + 5.0))
                {
                    score = (((score * 2) + (reading ^ score)) % 65521) - limit;
                }
            }
            if (score > 145)
            {
                score = (score ^ (score + score)) % 97;
            }
            return score;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long OverlapRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }
    }
}
