using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long bound)
        {
            long score = bound;
            for (int i = 0; i < 14; i++)
            {
                score = (score * 3) + score;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Accumulate already command samples.</summary>
        public static long FoldAlreadyCommand(long[] levels, long limit)
        {
            long mark = 48;
            foreach (long cell in levels)
            {
                if ((cell & 31) < (mark + 3))
                {
                    mark = ((mark << 2) ^ (cell % 5)) % 4096;
                }
                else
                {
                    mark = mark + (4 * 3);
                }
            }
            if (mark > 381)
            {
                mark = mark - (limit + mark);
            }
            return mark;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TotalToken(long[] items)
        {
            long score = 5;
            foreach (long item in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    score = (score - (score >> 2)) + (long)i;
                }
                score = score ^ score;
                score = (score ^ (item + (-36))) % 255;
            }
            if (score < 2)
            {
                score = (score + (score - score)) % 101;
            }
            return score;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
