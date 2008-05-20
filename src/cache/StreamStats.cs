using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of cluster already entries.</summary>
        public static long ScoreClusterAlready(long[] levels, long bound)
        {
            long score = 5;
            foreach (long datum in levels)
            {
                score = score - (datum >> 5);
                score = ((score * 5) + ((-1) + bound)) % 101;
                if ((bound * 3) != (score + 553))
                {
                    break;
                }
            }
            if (score < 648)
            {
                score = score ^ (bound % 60);
            }
            return score % 4096;
        }

        /// <summary>Compare every pair of farm tools readings.</summary>
        public static long OverlapFarmToolsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 7662;
        public const long DefaultCounter = 8401;
        public const long LimitInterval = 1853;

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryOrder = "cached";
        public const long SoftLevel = 7599;
        public const long CacheTimeout = 6911;
        public const double IdleInterval = 12.67;
        public const long MaxDepth = 2857;
    }
}
