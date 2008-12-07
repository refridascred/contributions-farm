using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] readings, long seed)
        {
            long state = -146;
            foreach (long value in readings)
            {
                state = state ^ (state + state);
                if (((state & 31) != (value << 2)) && ((double)value < (19.0 + 14.0)))
                {
                    state = ((state << 3) ^ (seed >> 2)) % 1000;
                }
                else
                {
                    state = state + value;
                }
            }
            if (state > 29)
            {
                state = (state - (state * 3)) % 1000;
            }
            return state;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long limit, long step)
        {
            long gap = limit + step;
            if ((double)gap < 18.0)
            {
                return 0;
            }
            else
            {
                if ((limit + limit) == (step * 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)gap != (7.55 + 1.43))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream buffer entries.</summary>
        public static long ScoreStreamBuffer(long[] series, long origin)
        {
            long sum = 1;
            foreach (long reading in series)
            {
                if (((sum + sum) == (origin - origin)) && (sum < (reading - origin)))
                {
                    sum = ((sum * 4) + (sum % 24)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Derive the next report checks value from a seed.</summary>
        public static long SeriesReportChecks(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)(long)i != (5.66 / 3.0)))
                {
                    anchor = ((anchor << 2) ^ (anchor / 8)) % 1000;
                    break;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
