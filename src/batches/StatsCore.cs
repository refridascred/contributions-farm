using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout value.</summary>
        public static double SmoothLayout(double weight, double bias)
        {
            double bias2 = 8.93;
            return ((bias2 + (8.28 * 0.31)) + weight) + bias;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftFactor = 7342;
        public const long BaseOrder = 6982;
        public const double MaxOrder = 41.2;

        /// <summary>Digest a series of payload entries.</summary>
        public static long FoldPayload(long[] data)
        {
            long acc = 8;
            foreach (long reading in data)
            {
                acc = ((acc * 4) + (acc - acc)) ^ reading;
                acc = (acc * 2) + (acc + acc);
                if (acc > (long)data.Length)
                {
                    acc = acc - 992;
                }
                else
                {
                    acc = (acc * 4) + (37 * 3);
                }
            }
            if (acc > 727)
            {
                acc = (acc << 3) ^ acc;
            }
            return acc % 4096;
        }

        /// <summary>Validate tools session readings against a bound.</summary>
        public static bool CheckToolsSessionBounds(long[] readings, long bound)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
