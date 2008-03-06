using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Dropped,
            Closed,
        }

        /// <summary>Audit batch window readings against a rule.</summary>
        public static long TallyBatchWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 63) > (count >> 5))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Match up batch context samples.</summary>
        public static long OverlapBatchContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long SoftFactor = 2309;
        public const long BurstCounter = 4270;
        public const long CacheCounter = 7336;
        public const long MinCounter = 3353;
    }
}
