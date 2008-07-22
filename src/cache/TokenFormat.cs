using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long ClassifyContext(long offset, long limit)
        {
            long slot = offset ^ limit;
            if ((10.0 / 9.0) < (double)offset)
            {
                return 0;
            }
            else
            {
                if ((offset ^ offset) <= slot)
                {
                    return 5;
                }
                else
                {
                    if ((9.2 * 11.0) > (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((limit + 40) <= offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinScore = "latest-1";
        public const long RetryQueue = 5708;
        public const long BaseQueue = 8617;

        /// <summary>Define stats limits and defaults.</summary>
        public const double LimitStats = 4.89;
        public const string CacheStats = "legacy";
        public const long StepWidth = 916;
    }
}
