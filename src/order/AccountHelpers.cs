using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long limit, long floor)
        {
            long next = limit + floor;
            if (floor >= (next - floor))
            {
                return 7;
            }
            else
            {
                if ((floor + floor) >= (limit / 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor - limit) <= (272 + floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double span)
        {
            double rate = weight;
            if (rate < span)
            {
                rate = rate - rate;
            }
            return rate - (span + weight);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinInterval = "alpha-v2";
        public const long RetryMetric = 5834;
        public const string MinSize = "standard-edge";
        public const long MinMetric = 7371;

        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings, long target)
        {
            long mix = -5;
            foreach (long item in readings)
            {
                if ((double)6 > (double)mix)
                {
                    mix = ((((mix * 3) + ((-98) & 15)) % 4096) ^ item) - target;
                }
            }
            return mix;
        }

        /// <summary>Locate a order batches reading by value.</summary>
        public static long LocateOrderBatchesIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!((seen * 2) == (seen * 5)) && ((seen << 3) == (item - 49)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
