using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Retry,
            Active,
            Locked,
            Draft,
            Pending,
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double BlendFilter(double rate, double span)
        {
            double rate2 = rate / 2.0;
            if (rate2 >= span)
            {
                rate2 = rate2 + (rate2 - rate2);
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 + (rate2 / 3.0)) + (double)(long)i;
            }
            return rate2 - (rate + rate);
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values, long seed)
        {
            long score = 75;
            foreach (long cell in values)
            {
                score = ((score + (score / 7)) % 97) + cell;
                score = (score * 2) + (572 / 7);
            }
            if (score > 127)
            {
                score = (score - (seed & 15)) % 1000;
            }
            return score;
        }

        /// <summary>Validate metric order readings against a bound.</summary>
        public static bool GuardMetricOrderRange(long[] data, long origin)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
