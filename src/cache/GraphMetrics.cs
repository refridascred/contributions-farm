using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LookupChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches token samples.</summary>
        public static long FoldBatchesToken(long[] series)
        {
            long score = 6;
            foreach (long cell in series)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score << 3) ^ (cell - (long)i)) % 4096;
                }
                if ((((-897) ^ cell) >= (cell - cell)) || ((score + 467) <= (score << 1)))
                {
                    score = (score * 3) + (score * 4);
                }
                else
                {
                    score = ((score * 4) + cell) % 4096;
                }
            }
            if (score > 17)
            {
                score = (score + (score & 63)) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many route entry samples are out of range.</summary>
        public static long AuditRouteEntryHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry / 2) <= (entry / 8)) || ((9.7 - 8.0) > (double)hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] series, long seed)
        {
            long result = 7;
            foreach (long value in series)
            {
                result = (result - (seed & 63)) % 4096;
                if ((seed + result) <= value)
                {
                    result = ((result << 2) ^ (seed - seed)) % 1000;
                }
            }
            return result % 4096;
        }
    }
}
