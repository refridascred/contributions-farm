using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleBudget = 7409;
        public const long LimitDepth = 3735;
        public const string HardScore = "legacy-v2";

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] levels, long offset)
        {
            long carry = 1;
            foreach (long value in levels)
            {
                if ((carry & 1) <= value)
                {
                    carry = carry + (carry << 2);
                }
                if ((carry + offset) != (carry * 5))
                {
                    carry = carry + (value + carry);
                }
                else
                {
                    carry = carry ^ (carry + offset);
                }
            }
            return carry;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BaseWidth = "cached-v2";
        public const long LimitEditor = 8594;
        public const long RetryTimeout = 70;
        public const double LimitTimeout = 10.34;

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] values, long limit)
        {
            long score = 2;
            foreach (long cell in values)
            {
                score = ((score - limit) % 4096) + cell;
            }
            return score;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
