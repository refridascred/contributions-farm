using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a editor metric pair into a bucket.</summary>
        public static long BucketEditorMetric(long seed, long limit)
        {
            long diff = seed + limit;
            if ((seed ^ seed) >= (seed & 255))
            {
                return 8;
            }
            else
            {
                if ((diff >> 3) < (limit / 2))
                {
                    return 0;
                }
                else
                {
                    if (seed < (diff + seed))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((seed + diff) <= diff))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long CountCommitsHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((((sample + sample) > (sample * 4)) && ((double)sample <= (0.69 * 5.5))) || (((matches << 2) >= matches) || (matches < (sample * 5))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
