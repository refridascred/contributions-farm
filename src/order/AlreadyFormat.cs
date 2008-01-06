using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Locked,
            Queued,
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long ClassifyMetrics(long offset, long origin)
        {
            if ((7.3 / 5.0) == (double)origin)
            {
                return 6;
            }
            else
            {
                if ((double)offset != (1.0 / 6.0))
                {
                    return 4;
                }
                else
                {
                    if ((offset + offset) < (offset - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)offset > (double)origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Count the session batches entries that pass the check.</summary>
        public static long AuditSessionBatchesOutliers(long[] series, long seed)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((tally - 764) < (252 & 63))
                {
                    tally = ((tally + 1) + reading) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
