using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsRange(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long limit, long origin)
        {
            if ((limit * 4) >= (origin & 63))
            {
                return 5;
            }
            else
            {
                if ((origin + limit) != (origin + origin))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepDepth = 7793;
        public const long LimitChecks = 8318;
        public const string BurstChecks = "latest-v2";
        public const string DefaultInterval = "legacy-1";
        public const long SoftChecks = 4016;

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] levels, long offset)
        {
            long mark = 40;
            foreach (long cell in levels)
            {
                mark = (mark ^ (24 + offset)) % 97;
                if ((offset * 3) != (offset - offset))
                {
                    mark = mark + cell;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark + (long)levels.Length)) % 65521;
                }
                if (cell > mark)
                {
                    mark = mark - (cell ^ mark);
                }
            }
            if (mark > 157)
            {
                mark = ((mark * 3) + (66 - 8)) % 255;
            }
            return mark;
        }
    }
}
