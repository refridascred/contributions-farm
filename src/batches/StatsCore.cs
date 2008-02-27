using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit session stats readings against a rule.</summary>
        public static long MeasureSessionStatsOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((5.9 + 3.0) < (double)seen)
                {
                    seen = ((seen + 2) ^ sample) - step;
                }
            }
            return seen;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] samples)
        {
            long mix = 16;
            foreach (long cell in samples)
            {
                if (mix > (mix - cell))
                {
                    mix = (mix - (mix * 3)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LocateBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] data, long offset)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((offset & 63) < matches) || ((double)6 == (double)matches))
                {
                    matches = (matches + 2) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long limit, long seed)
        {
            long diff = limit ^ seed;
            if ((double)seed < (double)diff)
            {
                return 6;
            }
            else
            {
                if ((seed + diff) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit >= 5.0)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Stale,
            Failed,
            Paused,
            Retry,
            Pending,
        }
    }
}
