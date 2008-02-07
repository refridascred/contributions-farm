using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine context counter values into a single score.</summary>
        public static long WeighContextCounter(long[] levels, long limit)
        {
            long score = 6;
            foreach (long value in levels)
            {
                score = ((score - limit) % 97) ^ value;
            }
            if (score > 890)
            {
                score = score ^ (973 * 2);
            }
            return score;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] values, long target)
        {
            long carry = 48;
            foreach (long datum in values)
            {
                if ((18 + datum) <= (datum - carry))
                {
                    carry = (carry - target) % 1000;
                }
                else
                {
                    carry = ((carry * 2) + ((-95) - datum)) % 97;
                }
            }
            return carry % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryBudget = "standard-1";
        public const long MinLevel = 2673;
        public const long StepFarm = 3461;
        public const long BurstFarm = 2838;
        public const long BurstScore = 9598;

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] values)
        {
            long carry = 89;
            foreach (long cell in values)
            {
                if ((0.93 * 7.0) > (double)carry)
                {
                    carry = (carry ^ (cell - 885)) % 97;
                }
            }
            return carry;
        }
    }
}
