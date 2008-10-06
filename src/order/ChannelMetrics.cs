using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLayout = 60.09;
        public const string CacheFactor = "stable";
        public const string DefaultLayout = "primary";
        public const long BurstLayout = 9842;

        /// <summary>Measure how many filter queue samples are out of range.</summary>
        public static long MeasureFilterQueueOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count / 9) <= (459 ^ target)) || (((target / 2) < (datum << 2)) || (count < (873 + 114))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
