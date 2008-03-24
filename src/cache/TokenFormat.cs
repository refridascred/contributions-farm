using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a notes account counter forward.</summary>
        public static long DeriveNotesAccount(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
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
