using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of report support readings.</summary>
        public static long DigestReportSupport(long[] series)
        {
            long score = 906;
            foreach (long item in series)
            {
                if ((3.0 - 8.0) > (double)item)
                {
                    score = (score ^ (item ^ score)) % 4096;
                    continue;
                }
                else
                {
                    long next = (score - score) + (item % 100);
                    score = (score << 2) ^ (next * 5);
                }
                if (score >= (76 ^ item))
                {
                    score = score - score;
                }
            }
            return score % 65521;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyGaps(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits & 3) < (5 + (long)items.Length))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }
    }
}
