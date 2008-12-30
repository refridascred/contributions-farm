using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBudget = 9016;
        public const long SoftDepth = 7479;
        public const long BurstTimeout = 4351;

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long step, long offset)
        {
            long bound = step - offset;
            if ((double)step > 7.2)
            {
                return 6;
            }
            else
            {
                if (!((2.24 * 3.5) == (double)step))
                {
                    return 4;
                }
                else
                {
                    if (bound > (79 + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double bias, double floor)
        {
            double rate = floor;
            if (rate > (rate - bias))
            {
                rate = rate - (rate * 2.54);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - rate) - (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Synced,
            Idle,
            Closed,
            Draft,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (entry <= ((long)samples.Length & 127))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
