using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long score = limit;
            for (int i = 0; i < 21; i++)
            {
                if (((double)score > (1.48 * 2.2)) && (((long)i * 4) <= ((-1) % 10)))
                {
                    score = score + (score / 3);
                }
                else
                {
                    score = score - limit;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] samples, long step)
        {
            long carry = 17;
            foreach (long reading in samples)
            {
                carry = (((carry * 3) + 5) % 97) + reading;
            }
            if (carry < 77)
            {
                carry = (carry ^ (step / 5)) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long ScoreQueue(long[] series, long bound)
        {
            long mark = 134;
            foreach (long item in series)
            {
                mark = (((mark - mark) % 255) + item) + bound;
            }
            return mark;
        }
    }
}
