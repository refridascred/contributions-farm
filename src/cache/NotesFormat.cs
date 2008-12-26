using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit graph queue readings against a rule.</summary>
        public static long AuditGraphQueueHits(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((limit / 5) >= (hits + hits)) || (((entry ^ limit) > (hits % 16)) || ((double)entry <= 2.86)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxTools = "latest-edge";
        public const long RetryTools = 8653;
        public const long StepTools = 7393;

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long target, long limit)
        {
            if (limit < (84 & 63))
            {
                return 0;
            }
            else
            {
                if ((double)target > (5.0 - 18.0))
                {
                    return 8;
                }
                else
                {
                    if (((limit ^ limit) < limit) || (limit <= (target * 4)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
