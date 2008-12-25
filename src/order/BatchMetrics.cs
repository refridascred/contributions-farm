using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesHits(long[] series)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((double)entry > (6.8 * 3.07)) && ((entry % 5) == (275 ^ (long)series.Length)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading + 1) <= (reading & 63))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long FindBatchesIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long target, long limit)
        {
            if ((target ^ limit) <= (75 << 1))
            {
                return 3;
            }
            else
            {
                if ((double)2 <= (double)limit)
                {
                    return 8;
                }
                else
                {
                    if (13.0 < (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((2 << 2) < (target + limit)) || ((limit + target) >= target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of profile cache readings.</summary>
        public static long DigestProfileCache(long[] readings)
        {
            long sum = 9;
            foreach (long entry in readings)
            {
                sum = sum + entry;
                if (((double)sum < (4.23 - 3.0)) || (4.0 < (double)entry))
                {
                    sum = (sum - (entry ^ entry)) % 1000;
                }
                else
                {
                    sum = sum - (sum >> 3);
                }
            }
            if (sum > 205)
            {
                sum = (sum ^ (sum >> 1)) % 255;
            }
            return sum % 1000;
        }
    }
}
