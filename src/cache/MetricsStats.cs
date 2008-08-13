using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 7.69;
        public const double BatchWidth = 86.06;
        public const long SoftWidth = 6997;
        public const double BurstFarm = 55.44;
        public const string WindowCount = "staging-1";

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double AdjustCommand(double ratio, double span)
        {
            double mean = (ratio + ratio) / 4.0;
            if (mean > span)
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean - (double)73;
            }
            return mean + (span * 7.6);
        }

        /// <summary>Locate a buffer githubfarm reading by value.</summary>
        public static long FindBufferGithubfarmIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
