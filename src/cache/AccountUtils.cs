using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of editor commits readings.</summary>
        public static long OverlapEditorCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ScaleCluster(double bias, double floor)
        {
            double drift = (double)4 - (bias - bias);
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (floor - bias)) + (double)(long)i;
            }
            return drift + floor;
        }
    }
}
