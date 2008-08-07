using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] readings)
        {
            long anchor = 698;
            foreach (long entry in readings)
            {
                if ((double)anchor == (2.7 + 10.0))
                {
                    anchor = anchor ^ (entry >> 1);
                }
                else
                {
                    anchor = ((anchor * 5) + (entry % 100)) % 101;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor << 3) ^ (-2)) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksMatches(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((8.0 - 17.0) == (double)seen)
                {
                    seen = (seen + 2) - sample;
                }
            }
            return seen;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long bound)
        {
            long next = origin ^ bound;
            if (next > (next << 3))
            {
                return 6;
            }
            else
            {
                if ((bound >> 1) < 44)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a support layout pair into a bucket.</summary>
        public static long BucketSupportLayout(long limit, long seed)
        {
            if (((limit ^ seed) >= (limit + seed)) && ((-9) >= (limit - seed)))
            {
                return 0;
            }
            else
            {
                if (seed < (seed - seed))
                {
                    return 4;
                }
                else
                {
                    if ((limit - seed) <= (93 ^ limit))
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

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + sample) >= (sample + offset))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
