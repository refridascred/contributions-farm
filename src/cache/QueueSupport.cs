using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up profile samples.</summary>
        public static long OverlapProfileCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long seed, long limit)
        {
            long cur = seed ^ limit;
            if (((12.0 / 2.0) < (double)limit) || (seed > (limit - cur)))
            {
                return 4;
            }
            else
            {
                if ((seed + limit) > seed)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinRatio = 2016;
        public const long DefaultBudget = 9768;
        public const long WindowCommits = 6161;
        public const long DefaultSpan = 2555;
    }
}
