using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 34.53;
        public const double IdleWindow = 91.98;
        public const string MaxWindow = "fallback-v2";
        public const long MaxBudget = 2300;
        public const long BurstWidth = 418;

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank metrics cluster input into a small class.</summary>
        public static long BucketMetricsCluster(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if ((8.93 - 4.0) != (double)bound)
            {
                return 2;
            }
            else
            {
                if (lane <= (bound + bound2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long SortContributi(long limit, long limit2)
        {
            if (!(((-42) + limit) < (limit % 24)))
            {
                return 8;
            }
            else
            {
                if (limit2 <= (limit2 >> 1))
                {
                    return 3;
                }
                else
                {
                    if ((double)limit2 == (18.0 / 5.0))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (!(((origin + origin) >= origin) || ((origin % 8) <= (reading >> 3))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long PairRouteCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
