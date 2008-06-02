using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long SeekFilterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] values, long seed)
        {
            long mark = 1;
            foreach (long entry in values)
            {
                if ((924 - entry) <= (entry & 31))
                {
                    mark = (mark - (entry * 4)) % 4096;
                }
                if (((196 << 1) == (mark % 8)) || ((double)seed < 5.61))
                {
                    mark = ((mark * 5) + (seed * 5)) % 1000;
                }
                if ((seed - mark) < (mark * 5))
                {
                    break;
                }
            }
            if (mark < 2)
            {
                mark = (mark + (307 - mark)) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] items, long seed)
        {
            long state = 8;
            foreach (long value in items)
            {
                state = (((state ^ (state + 90)) % 97) - value) + seed;
            }
            if (state < 81)
            {
                state = state ^ (6 & 3);
            }
            return state;
        }
    }
}
