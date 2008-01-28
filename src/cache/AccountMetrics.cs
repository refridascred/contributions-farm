using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderGaps(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((4.52 * 9.23) == (double)hits)
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route account samples are out of range.</summary>
        public static long TallyRouteAccountGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (tally < (entry << 1))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool GuardCommitsRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up profile samples.</summary>
        public static long MatchProfileCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit record window readings against a rule.</summary>
        public static long TallyRecordWindowOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)hits <= (double)bound)
                {
                    hits = (hits + 3) ^ reading;
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
