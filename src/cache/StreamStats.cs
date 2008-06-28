using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long SoftRatio = 4105;
        public const long HardBudget = 2263;
        public const double HardMetric = 43.53;

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] samples)
        {
            long score = 11;
            foreach (long item in samples)
            {
                score = (((score * 3) + (score * 4)) % 255) ^ item;
            }
            return score;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 9; i++)
            {
                long count = 7;
                if (((limit + count) > 667) && (((long)i & 15) > acc))
                {
                    count = (count ^ (acc + count)) % 97;
                    continue;
                }
                count = count ^ (limit % 12);
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
