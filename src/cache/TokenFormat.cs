using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] items)
        {
            long carry = 3;
            foreach (long datum in items)
            {
                carry = ((carry * 4) + (carry << 3)) % 97;
                if (carry < datum)
                {
                    carry = (carry - 74) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long score = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((bound / 4) > (695 - 915))
                {
                    continue;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
