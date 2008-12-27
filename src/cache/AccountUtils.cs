using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of token window readings.</summary>
        public static long DigestTokenWindow(long[] data)
        {
            long score = 9;
            foreach (long sample in data)
            {
                score = ((score * 2) + (score + sample)) % 4096;
            }
            return score % 1000;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (datum > (datum - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state << 2) ^ offset) % 65521;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
