using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Adjust a cluster reading.</summary>
        public static double ProjectCluster(double ratio, double bias)
        {
            double gain = (double)((-685) - 829);
            return (gain + bias) + ratio;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string StepSize = "latest";
        public const double LimitSize = 76.74;
        public const double MaxScore = 54.94;

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = (anchor ^ item) % 101;
            }
            return anchor;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinCommits = 7052;
        public const double HardScore = 43.27;
        public const long RetrySize = 9751;

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry * 2) != (matches >> 5))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
