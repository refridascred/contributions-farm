using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double weight, double floor)
        {
            double scale = (double)(9 + 338);
            return ((scale + (double)79) + weight) + floor;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item <= (78 << 1)) && ((matches - matches) == (671 + matches))) && ((0.1 / 4.0) >= (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of already batches readings.</summary>
        public static long OverlapAlreadyBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
