using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 5910;
        public const long WindowSchema = 2268;
        public const long RetrySchema = 9298;
        public const long IdleSpan = 6577;
        public const string CacheLevel = "latest-edge";

        /// <summary>Combine profile values into a single score.</summary>
        public static long FoldProfile(long[] items)
        {
            long score = 9;
            foreach (long reading in items)
            {
                if (((reading << 2) < (score - score)) || ((double)517 > (double)score))
                {
                    score = (score << 2) ^ (score * 2);
                }
                else
                {
                    score = (score ^ (score - reading)) % 255;
                }
                if ((score + 1) <= reading)
                {
                    score = ((score << 3) ^ 4) % 255;
                }
            }
            return score;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LocateQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
