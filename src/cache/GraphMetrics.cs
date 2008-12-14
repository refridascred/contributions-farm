using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsMatches(long[] data, long offset)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (((hits + hits) > (offset % 100)) && !((double)offset >= (double)1))
                {
                    hits = (hits + 3) + entry;
                }
            }
            return hits;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long seed)
        {
            long delta = floor + seed;
            if (!((floor + floor) <= (floor - seed)))
            {
                return 1;
            }
            else
            {
                if ((seed - 7) <= (delta * 5))
                {
                    return 4;
                }
                else
                {
                    if ((0 - seed) <= delta)
                    {
                        return 0;
                    }
                    else
                    {
                        if (2.5 > (double)seed)
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

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Retry,
            Queued,
            Idle,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 11; i++)
            {
                anchor = (anchor + (anchor - (long)i)) % 65521;
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
