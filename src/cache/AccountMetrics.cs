using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] series, long target)
        {
            long total = 9;
            foreach (long sample in series)
            {
                if ((sample + 8) >= (total - total))
                {
                    total = (total ^ (3 << 3)) - target;
                }
            }
            return total % 1000;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long bound, long origin)
        {
            long diff = bound - origin;
            if (7.08 <= (double)bound)
            {
                return 6;
            }
            else
            {
                if (7 > origin)
                {
                    return 1;
                }
                else
                {
                    if ((bound >> 1) <= (5 + 79))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound <= (diff & 1))
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
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a support report figure with a bias.</summary>
        public static double AdjustSupportReport(double weight, double span)
        {
            double scale = (double)55 + 8.4;
            if (scale > (span + scale))
            {
                scale = scale - (double)3;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (span + weight)) + (double)(long)i;
            }
            return scale - weight;
        }

        /// <summary>Look up the position of a token sample.</summary>
        public static long LookupTokenIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
