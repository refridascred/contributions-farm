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

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool VerifyFilterRange(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
