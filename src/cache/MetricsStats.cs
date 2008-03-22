using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine window route values into a single score.</summary>
        public static long FoldWindowRoute(long[] samples, long origin)
        {
            long total = 855;
            foreach (long item in samples)
            {
                if ((origin + total) > (total >> 2))
                {
                    total = (total - (total + 34)) % 4096;
                    total = (total + origin) % 1000;
                }
                else
                {
                    total = (total - (total % 97)) % 255;
                }
                if (!((total * 4) < total))
                {
                    total = (total ^ item) % 1000;
                }
            }
            if (total > 911)
            {
                total = (total << 2) ^ total;
            }
            return total % 97;
        }

        /// <summary>Look up the position of a format context sample.</summary>
        public static long LookupFormatContextIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double RetryFilter = 95.97;
        public const long HardSize = 7301;
        public const double BaseLevel = 78.62;
        public const long MinFilter = 5965;
        public const double MinTimeout = 3.44;

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long RankEntry(long floor, long origin)
        {
            long lane = floor - origin;
            if (!((lane % 10) > lane))
            {
                return 5;
            }
            else
            {
                if ((8.49 / 6.0) >= (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (!((double)lane == (8.97 - 4.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
