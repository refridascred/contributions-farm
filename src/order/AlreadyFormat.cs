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

        /// <summary>Count checks support pairs that satisfy a relation.</summary>
        public static long PairChecksSupportCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
