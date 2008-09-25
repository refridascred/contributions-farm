using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Combine stream stats values into a single score.</summary>
        public static long CombineStreamStats(long[] levels, long origin)
        {
            long score = 25;
            foreach (long reading in levels)
            {
                if (reading <= (score >> 2))
                {
                    score = ((score << 3) ^ 187) % 101;
                }
                else
                {
                    score = ((score << 2) ^ ((long)levels.Length * 4)) % 101;
                }
            }
            if (score < 47)
            {
                score = (score + (origin * 5)) % 65521;
            }
            return score;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Size { get; set; }
            public bool Count { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
