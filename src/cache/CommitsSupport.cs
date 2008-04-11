using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long origin, long seed)
        {
            long delta = origin + seed;
            if ((seed - origin) < (9 << 2))
            {
                return 2;
            }
            else
            {
                if ((double)delta <= 1.0)
                {
                    return 7;
                }
                else
                {
                    if ((delta + origin) == (seed + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((delta - delta) >= (seed * 5))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally / 8) < datum)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 8980;
        public const long CacheRatio = 283;
        public const string BatchChannel = "fallback";
        public const string SoftFactor = "strict";
        public const double MaxChannel = 23.13;

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - seed) % 65521;
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long PairFarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double bias)
        {
            double bias2 = ratio;
            return bias2 + bias;
        }
    }
}
