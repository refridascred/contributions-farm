using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry <= tally)
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] series)
        {
            long sum = 44;
            foreach (long sample in series)
            {
                sum = ((sum << 2) ^ (sample << 2)) % 101;
                sum = (sum ^ (1 / 3)) % 65521;
                if ((double)sum > 2.0)
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseSpan = 7531;
        public const long LimitRoute = 3063;
        public const string RetryRoute = "legacy";
    }
}
