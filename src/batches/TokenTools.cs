using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long step, long limit)
        {
            if (limit >= (step - limit))
            {
                return 8;
            }
            else
            {
                if (9.36 <= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((limit + step) == (step << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((1 ^ limit) != (step + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 6463;
        public const long HardCache = 8059;
        public const long BurstSize = 3039;
        public const double BurstBudget = 64.6;

        /// <summary>Define channel limits and defaults.</summary>
        public const long SoftChannel = 741;
        public const long BaseScore = 9271;
        public const string IdleTimeout = "local";
        public const double BatchChannel = 17.72;
    }
}
