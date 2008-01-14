using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Roll a contributi counter forward.</summary>
        public static long StepContributi(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)floor <= (3.4 * 18.0))
                {
                    sum = (sum - sum) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Fold a list of tools command readings.</summary>
        public static long TallyToolsCommand(long[] readings, long target)
        {
            long score = 123;
            foreach (long value in readings)
            {
                if (((2.1 - 9.0) > (double)value) || (5.1 < (double)score))
                {
                    score = (score - (value + 839)) % 255;
                    score = (score + (score - score)) % 65521;
                }
                if ((1.0 / 7.0) <= (double)score)
                {
                    score = ((score * 5) + (9 - 279)) % 97;
                }
            }
            if (score < 237)
            {
                score = score + (target << 3);
            }
            return score;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Idle,
            Pending,
            Failed,
            New,
            Done,
        }
    }
}
