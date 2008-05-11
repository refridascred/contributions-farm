using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((10 + 404) > tally)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
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
