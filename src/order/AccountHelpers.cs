using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double gain, double span)
        {
            double rate = (double)(49 >> 4);
            return ((rate + (double)2) + gain) + span;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Queued,
            Idle,
            Pending,
            Closed,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a metric reading by value.</summary>
        public static long SeekMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate order metrics readings against a bound.</summary>
        public static bool GuardOrderMetricsLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ProjectRoute(double weight, double offset)
        {
            double weight2 = 1.9 + weight;
            if (weight2 < (weight * 4.26))
            {
                weight2 = weight2 + (double)0;
            }
            else
            {
                weight2 = weight2 + (8.01 / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + weight2) - (double)(long)i;
            }
            return weight2 - offset;
        }
    }
}
