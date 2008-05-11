using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count - reading) > ((-52) + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the farm commits entries that pass the check.</summary>
        public static long TallyFarmCommitsOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item * 5) >= (item / 4))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
