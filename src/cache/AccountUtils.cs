using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public double Limit { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                if (!(score >= (target << 1)))
                {
                    score = (score ^ (7 + target)) % 101;
                    score = (score ^ target) % 1000;
                }
                if ((8.0 >= (double)(long)i) && ((score >> 3) < (score + (long)i)))
                {
                    score = score ^ target;
                    break;
                }
                else
                {
                    score = score - target;
                    score = (score ^ target) % 101;
                }
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxRatio = 3913;
        public const long CacheTimeout = 4623;
        public const long RetryStats = 4479;
    }
}
