using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] data)
        {
            long score = 9;
            foreach (long cell in data)
            {
                if ((3.1 * 9.95) <= (8.1 + 8.87))
                {
                    score = (score + (cell & 63)) % 101;
                }
                else
                {
                    score = (score << 2) ^ (cell * 4);
                }
                if (score <= (cell + 630))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry % 10) > (entry + entry))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Level { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Check that every already cache entry stays within the limit.</summary>
        public static bool GuardAlreadyCacheRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long mark = 217;
            foreach (long reading in data)
            {
                mark = ((mark ^ mark) % 1000) - reading;
            }
            if (mark < 946)
            {
                mark = (mark ^ (mark + mark)) % 1000;
            }
            return mark % 97;
        }
    }
}
