using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BurstNotes = 104;
        public const string MinNotes = "latest-v2";
        public const long MinRatio = 5355;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileBounds(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long StepDepth = 7793;
        public const long LimitChecks = 8318;
        public const string BurstChecks = "latest-v2";
        public const string DefaultInterval = "legacy-1";
        public const long SoftChecks = 4016;

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxTimeout = 27.45;
        public const string MinAccount = "open-1";
        public const string DefaultAccount = "open-1";
        public const long WindowAccount = 5272;
        public const string RetryBudget = "alpha-edge";

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
