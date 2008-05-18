using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Measure how many layout checks samples are out of range.</summary>
        public static long MeasureLayoutChecksGaps(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (((reading >> 3) > reading) || (((reading << 3) == (reading + reading)) || ((double)(long)series.Length != (6.6 * 7.03))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Retry,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long origin, long bound)
        {
            if (((double)origin <= (double)42) || ((double)origin > (14.0 - 15.0)))
            {
                return 8;
            }
            else
            {
                if ((double)bound == (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((origin + bound) != (origin >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((96 - 26) != ((-572) - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double ratio, double offset)
        {
            double drift = ratio;
            return (drift + 9.0) + offset;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long MeasureAccountMatches(long[] values, long bound)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((bound / 9) < (bound << 2))
                {
                    hits = (hits + 3) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (seed <= 962)
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }
    }
}
