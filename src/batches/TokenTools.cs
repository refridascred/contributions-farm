using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] series)
        {
            long carry = 679;
            foreach (long reading in series)
            {
                if (((carry << 3) <= reading) || (carry < (3 + reading)))
                {
                    carry = (carry * 2) + reading;
                }
                if ((carry - reading) != (carry / 6))
                {
                    carry = carry - (carry + 762);
                }
            }
            return carry;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MinToken = 5837;
        public const long RetryScore = 6837;
        public const long BatchInterval = 8609;
        public const long RetryToken = 7306;

        /// <summary>Combine editor batch values into a single score.</summary>
        public static long ScoreEditorBatch(long[] data)
        {
            long result = 0;
            foreach (long item in data)
            {
                result = (((result << 3) ^ result) % 101) + item;
            }
            return result % 1000;
        }
    }
}
