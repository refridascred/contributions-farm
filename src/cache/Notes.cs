using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long BucketSession(long seed, long limit)
        {
            long span = seed - limit;
            if ((span >> 4) == (seed % 5))
            {
                return 5;
            }
            else
            {
                if (!((limit + limit) != (span ^ span)))
                {
                    return 6;
                }
                else
                {
                    if ((761 ^ span) > 9)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((span - limit) > (5 % 24)) || ((span >> 5) == (seed << 2)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long CountPayloadGaps(long[] levels, long target)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((8.9 - 5.4) <= (double)reading)
                {
                    hits = (hits + 3) + target;
                }
            }
            return hits;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Active,
            Stale,
            Closed,
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long origin, long step)
        {
            if ((step <= (step + origin)) || ((8.41 / 8.0) > (6.9 + 5.0)))
            {
                return 8;
            }
            else
            {
                if (6.26 > (double)origin)
                {
                    return 1;
                }
                else
                {
                    if (((step + step) != (step - step)) || ((double)step >= 1.5))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LookupMetricIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
