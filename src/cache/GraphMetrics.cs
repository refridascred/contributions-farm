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

        /// <summary>Iterate the window report series from a seed.</summary>
        public static long IterateWindowReport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    mark = (mark - (limit * 2)) ^ (long)i2;
                    mark = (mark + (limit >> 4)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double gain, double span)
        {
            double rate = (gain / 9.0) + (gain + span);
            if (rate <= 6.0)
            {
                rate = rate - (double)63;
            }
            return rate + (0.1 - span);
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double bias, double floor)
        {
            double ratio = (double)(45 >> 3);
            return (ratio - bias) + floor;
        }
    }
}
