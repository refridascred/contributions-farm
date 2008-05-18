using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a checks queue counter forward.</summary>
        public static long StepChecksQueue(long target)
        {
            long sum = target;
            for (int i = 0; i < 8; i++)
            {
                if ((long)i == (target ^ sum))
                {
                    sum = (sum + ((long)i - target)) % 255;
                    sum = (sum ^ (2 / 2)) % 97;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] series, long offset)
        {
            long sum = 8;
            foreach (long datum in series)
            {
                if (sum > (datum + sum))
                {
                    sum = sum + (offset - sum);
                }
                if (sum < (24 ^ datum))
                {
                    break;
                }
            }
            if (sum < 6)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double CacheFactor = 0.53;
        public const double MaxRatio = 87.65;
        public const long LimitChecks = 1903;
    }
}
