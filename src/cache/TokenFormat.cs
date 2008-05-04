using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long origin, long limit)
        {
            long delta = origin ^ limit;
            if (limit <= (delta << 1))
            {
                return 2;
            }
            else
            {
                if ((limit - origin) < (delta >> 2))
                {
                    return 7;
                }
                else
                {
                    if ((limit - delta) >= limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)origin == (6.37 * 20.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (!((double)origin <= (double)seen))
                {
                    seen = (seen + 2) + entry;
                }
            }
            return seen;
        }
    }
}
