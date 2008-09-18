using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Stale,
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Count queue cluster pairs that satisfy a relation.</summary>
        public static long MatchQueueClusterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsBounds(long[] levels, long bound)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double scale, double span)
        {
            double drift = (double)(965 + 18);
            return ((drift - (double)3) + scale) + span;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double ratio = (double)(45 >> 3);
            return (ratio - bias) + floor;
        }
    }
}
