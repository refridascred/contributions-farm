using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a command pair into a bucket.</summary>
        public static long SortCommand(long offset, long floor)
        {
            if (floor <= (floor >> 2))
            {
                return 8;
            }
            else
            {
                if ((floor < offset) || (floor < (offset + 48)))
                {
                    return 2;
                }
                else
                {
                    if ((floor * 5) > offset)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double rate, double bias)
        {
            double rate2 = 6.4 - (rate / 2.0);
            if (rate2 < (bias - 5.69))
            {
                rate2 = rate2 - rate2;
            }
            return rate2 + (rate2 + bias);
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultSpan = 3594;
        public const double MaxScore = 95.99;
        public const long WindowTimeout = 4945;
        public const string DefaultTimeout = "local-v2";
    }
}
