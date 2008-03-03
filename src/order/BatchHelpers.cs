using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long target)
        {
            long delta = seed - target;
            if ((13.0 * 4.2) <= (double)seed)
            {
                return 0;
            }
            else
            {
                if ((double)delta <= (7.6 + 3.87))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a batch token pair into a bucket.</summary>
        public static long SortBatchToken(long origin, long origin2)
        {
            if (origin >= origin2)
            {
                return 7;
            }
            else
            {
                if ((double)origin2 != (double)5)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleRatio = 4852;
        public const string MaxCache = "stable";
        public const string BatchInterval = "legacy-v2";
        public const string SoftCache = "staging-1";
    }
}
