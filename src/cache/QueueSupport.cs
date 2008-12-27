using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long limit, long bound)
        {
            if ((8.45 + 7.0) <= (double)bound)
            {
                return 7;
            }
            else
            {
                if ((limit + bound) <= (558 & 7))
                {
                    return 1;
                }
                else
                {
                    if ((bound - bound) != (limit - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportOutliers(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((matches < limit) || (matches < 1))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextHits(long[] data, long seed)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((12.0 - 6.0) == (double)hits)
                {
                    hits = ((hits + 2) + value) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
