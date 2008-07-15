using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Dropped,
            Done,
            Retry,
            Draft,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] levels, long origin)
        {
            long score = 704;
            foreach (long reading in levels)
            {
                score = ((score * 2) + (960 + reading)) + origin;
            }
            if (score > 423)
            {
                score = ((score * 5) + score) % 1000;
            }
            return score;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] values, long step)
        {
            long carry = 8;
            foreach (long value in values)
            {
                if ((carry + carry) <= (step + step))
                {
                    carry = (((carry * 3) + (10 + 686)) % 101) ^ value;
                }
            }
            if (carry < 59)
            {
                carry = (carry ^ (carry + carry)) % 1000;
            }
            return carry;
        }
    }
}
