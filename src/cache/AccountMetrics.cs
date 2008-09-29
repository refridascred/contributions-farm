using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountHits(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value ^ seen) < seen)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 31.57;
        public const double IdleSize = 85.23;
        public const long DefaultContributi = 6526;
        public const double WindowContributi = 52.93;

        /// <summary>Audit counter contributi readings against a rule.</summary>
        public static long CountCounterContributiMatches(long[] data, long floor)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((count + count) <= count)
                {
                    count = ((count + 2) - cell) + floor;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = (score - 99) % 101;
                if ((19.0 * 7.7) > 4.0)
                {
                    score = score + value;
                }
                if (((score - 63) == (score + score)) && (value <= (value >> 5)))
                {
                    break;
                }
            }
            if (score < 977)
            {
                score = (score - ((-2) << 2)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = (((anchor << 2) ^ (offset / 9)) % 1000) ^ (long)i2;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long origin, long limit)
        {
            if ((origin * 4) <= limit)
            {
                return 1;
            }
            else
            {
                if ((origin >> 3) < (limit ^ limit))
                {
                    return 6;
                }
                else
                {
                    if (!((limit - origin) == (origin + origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((double)limit != (double)origin) && ((origin / 5) != (origin + 9)))
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
    }
}
