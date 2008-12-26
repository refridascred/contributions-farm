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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long floor, long step)
        {
            if ((double)floor == (8.1 - 7.99))
            {
                return 7;
            }
            else
            {
                if ((double)38 != (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((floor - floor) <= floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step >= (1.8 - 15.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (((6.22 * 17.0) >= (double)reading) && ((reading >> 3) <= (488 - 665)))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }
    }
}
