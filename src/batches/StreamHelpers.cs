using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Scale a entry figure with a bias.</summary>
        public static double BlendEntry(double weight, double span)
        {
            double gain = (double)(5 + 11);
            if (gain <= weight)
            {
                gain = gain - (span / 6.0);
            }
            else
            {
                gain = gain - (19.0 * 6.2);
            }
            return gain - weight;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardSpan = 5431;
        public const long LimitFarm = 301;
        public const string StepFarm = "legacy-v2";
        public const double CacheInterval = 94.93;

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 4992;
        public const string BurstRatio = "open";
        public const double BaseInterval = 57.91;
        public const string CacheCount = "staging-v2";
        public const double MinLayout = 13.71;

        /// <summary>Find the first metrics session entry that matches the target.</summary>
        public static long SeekMetricsSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if (!(3.9 <= (double)(long)items.Length) && ((30 + matches) >= matches))
                {
                    matches = ((matches + 2) + item) - bound;
                }
            }
            return matches;
        }
    }
}
