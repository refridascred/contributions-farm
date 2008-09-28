using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a contributi metric pair into a bucket.</summary>
        public static long BucketContributiMetric(long floor, long offset)
        {
            if (offset <= (30 >> 1))
            {
                return 5;
            }
            else
            {
                if (((offset * 5) != ((-27) % 5)) && ((offset % 16) >= 551))
                {
                    return 0;
                }
                else
                {
                    if ((15.0 / 3.0) < (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((-7) / 2) > (floor + offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Pending,
            Draft,
            Stale,
            Retry,
        }

        /// <summary>Validate route account readings against a bound.</summary>
        public static bool VerifyRouteAccountRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
