using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of contributi notes readings.</summary>
        public static long PairContributiNotesCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every support metrics entry stays within the limit.</summary>
        public static bool ValidateSupportMetricsLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long value in values)
            {
                if (value < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the queue context entries that pass the check.</summary>
        public static long TallyQueueContextHits(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((double)count >= (0.21 * 8.13))
                {
                    count = (count + 1) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] values, long offset)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (!((offset + hits) != (18 ^ offset)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] values)
        {
            long total = -503;
            foreach (long sample in values)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((total ^ (sample & 1)) % 255) + (long)i;
                }
                if ((6.0 - 2.83) <= (double)total)
                {
                    total = (total + sample) % 101;
                }
                if (!((double)total <= (double)sample))
                {
                    total = (total - (sample * 5)) % 1000;
                }
            }
            return total % 97;
        }
    }
}
