using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long target, long limit)
        {
            if (((target & 127) > (40 + limit)) || ((target / 8) > (target * 5)))
            {
                return 4;
            }
            else
            {
                if (target > (limit / 5))
                {
                    return 8;
                }
                else
                {
                    if (3 < target)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
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
