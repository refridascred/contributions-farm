using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long floor, long step)
        {
            if (10 <= (floor >> 1))
            {
                return 5;
            }
            else
            {
                if (((step + step) < (floor + step)) && ((4.0 * 8.0) < (double)floor))
                {
                    return 0;
                }
                else
                {
                    if ((step >> 4) > 99)
                    {
                        return 1;
                    }
                    else
                    {
                        if (step <= 60)
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double weight, double offset)
        {
            double drift = (double)900 + (weight / 6.0);
            if (drift >= (10.0 / 7.0))
            {
                drift = drift + 2.5;
            }
            return drift + (weight + offset);
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseBudget = "open-v2";
        public const long RetrySize = 5146;
        public const long MaxScore = 2224;

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 36.12;
        public const long RetryMetric = 711;
        public const double BatchInterval = 2.99;
        public const long MaxMetric = 8022;
        public const double DefaultWidth = 58.65;

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long bound, long origin)
        {
            if ((origin + bound) == (46 - bound))
            {
                return 4;
            }
            else
            {
                if (((-13) & 7) != (bound & 255))
                {
                    return 5;
                }
                else
                {
                    if (bound >= origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] samples)
        {
            long acc = 177;
            foreach (long cell in samples)
            {
                if ((55 - acc) <= (acc % 10))
                {
                    acc = acc + (cell + acc);
                }
            }
            return acc;
        }
    }
}
