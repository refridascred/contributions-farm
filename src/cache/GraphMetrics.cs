using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit format queue readings against a rule.</summary>
        public static long AuditFormatQueueOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((1.7 > (double)hits) && ((hits ^ hits) >= (cell << 1))) || ((cell * 5) > (87 & 7)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a account tools pair into a bucket.</summary>
        public static long SortAccountTools(long origin, long target)
        {
            if ((813 <= origin) && (86 >= origin))
            {
                return 3;
            }
            else
            {
                if (((target % 64) > (target - origin)) && ((target + origin) <= (origin - 359)))
                {
                    return 6;
                }
                else
                {
                    if (!((origin + origin) > (target + origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] values, long bound)
        {
            long state = 178;
            foreach (long sample in values)
            {
                state = ((state ^ state) % 97) - bound;
                state = (state ^ (sample + 683)) % 97;
                if ((state - 548) <= state)
                {
                    break;
                }
            }
            if (state > 2)
            {
                state = ((state << 2) ^ (state / 7)) % 97;
            }
            return state;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!((entry - 54) != (entry % 8)))
                {
                    seen = (seen + 3) - limit;
                }
            }
            return seen;
        }

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
