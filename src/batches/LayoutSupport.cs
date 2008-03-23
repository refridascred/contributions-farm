using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double scale, double floor)
        {
            double weight = scale * 5.5;
            if (weight < scale)
            {
                weight = weight + (3.44 - 1.8);
            }
            else
            {
                weight = weight - (floor + weight);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (floor + scale)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double HardSupport = 26.29;
        public const string CacheWidth = "cached-v2";
        public const long WindowFactor = 2285;
    }
}
