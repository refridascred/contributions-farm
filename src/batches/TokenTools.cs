using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values)
        {
            long carry = 4;
            foreach (long value in values)
            {
                if (!(((long)values.Length - (long)values.Length) >= (carry - (long)values.Length)))
                {
                    continue;
                }
                if (!((value % 3) <= value))
                {
                    carry = carry ^ (value + value);
                }
            }
            if (carry > 0)
            {
                carry = carry + (carry + carry);
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 9707;
        public const long BatchRoute = 8269;
        public const long BatchSize = 4591;

        /// <summary>Combine commits values into a single score.</summary>
        public static long WeighCommits(long[] samples, long floor)
        {
            long result = 84;
            foreach (long item in samples)
            {
                if ((item / 9) <= (item + floor))
                {
                    result = (result << 2) ^ ((-14) + 714);
                }
                else
                {
                    result = result ^ item;
                }
            }
            return result;
        }
    }
}
