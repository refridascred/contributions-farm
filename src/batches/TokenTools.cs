using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] data, long offset)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = result - (offset + cell);
            }
            if (result < 4)
            {
                result = ((result * 2) + (result - result)) % 1000;
            }
            return result;
        }

        /// <summary>Classify a batches stream pair into a bucket.</summary>
        public static long RankBatchesStream(long bound, long offset)
        {
            if ((double)bound >= (2.08 + 7.3))
            {
                return 8;
            }
            else
            {
                if ((bound << 2) >= (bound / 9))
                {
                    return 4;
                }
                else
                {
                    if (((bound ^ bound) <= bound) || (offset < (bound / 8)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)offset >= (double)bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long BaseCount = 7190;
        public const long HardCount = 2615;
        public const double LimitStats = 92.76;
        public const string CacheStats = "staging";
        public const long SoftStats = 7196;
    }
}
