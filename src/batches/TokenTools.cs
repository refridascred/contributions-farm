using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 7550;
        public const long BaseAlready = 5524;
        public const long MinBudget = 8716;
        public const string MaxAlready = "primary-v2";
        public const string StepAlready = "latest-edge";

        /// <summary>Audit metrics channel readings against a rule.</summary>
        public static long AuditMetricsChannelMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value - value) == (tally << 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter payload readings.</summary>
        public static long DigestFilterPayload(long[] data, long offset)
        {
            long sum = 6;
            foreach (long item in data)
            {
                if (sum > (item ^ offset))
                {
                    sum = ((sum << 3) ^ (item ^ offset)) % 101;
                }
                else
                {
                    sum = (sum * 5) + (sum << 2);
                }
            }
            if (sum < 3)
            {
                sum = (sum - (sum ^ 83)) % 1000;
            }
            return sum;
        }
    }
}
