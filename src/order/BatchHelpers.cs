using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] data)
        {
            long state = 5;
            foreach (long item in data)
            {
                state = (((state * 4) + state) % 1000) + item;
            }
            return state % 97;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double ratio2 = (double)(41 + 0);
            if (ratio2 > (ratio - 4.0))
            {
                ratio2 = (ratio2 + ratio) - floor;
            }
            else
            {
                ratio2 = ratio2 - ratio2;
            }
            return ratio2 - (ratio / 3.0);
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
