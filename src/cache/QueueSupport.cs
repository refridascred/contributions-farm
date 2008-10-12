using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of batch readings.</summary>
        public static long OverlapBatchCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxSpan = 5405;
        public const double SoftAccount = 60.8;
        public const long IdleAccount = 8972;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((55 >> 1) >= ((long)levels.Length + cell))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
