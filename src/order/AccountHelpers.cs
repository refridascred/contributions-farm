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

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long value in items)
            {
                if ((value + seed) < (value % 16))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
