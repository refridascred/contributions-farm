using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double weight, double floor)
        {
            double weight2 = floor;
            if (weight2 < (weight2 * 5.0))
            {
                weight2 = (weight2 - (floor * 13.0)) + weight;
            }
            else
            {
                weight2 = weight2 - (floor * 1.55);
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + (floor / 2.0)) + (double)(long)i;
            }
            return weight2 - (double)1;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
