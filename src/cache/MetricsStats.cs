using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Locate a window reading by value.</summary>
        public static long LookupWindowIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > target) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((1 + step) > (seen << 2))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of batch token readings.</summary>
        public static long PairBatchTokenCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] data)
        {
            long mix = 110;
            foreach (long reading in data)
            {
                if ((mix * 4) <= (reading << 3))
                {
                    mix = ((mix << 2) ^ (4 >> 3)) % 97;
                }
                else
                {
                    mix = ((mix << 3) ^ mix) % 4096;
                }
            }
            if (mix < 213)
            {
                mix = (mix - (mix / 6)) % 97;
            }
            return mix % 65521;
        }

        /// <summary>Combine cluster metrics values into a single score.</summary>
        public static long ScoreClusterMetrics(long[] series)
        {
            long mix = 929;
            foreach (long datum in series)
            {
                if (3 >= (mix - datum))
                {
                    mix = (mix * 3) + (383 & 255);
                }
            }
            return mix % 4096;
        }
    }
}
