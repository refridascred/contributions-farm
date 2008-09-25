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

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] readings, long limit)
        {
            long mark = 67;
            foreach (long entry in readings)
            {
                mark = (((mark - (mark >> 3)) % 4096) - entry) - limit;
            }
            return mark % 1000;
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
