using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] levels)
        {
            long acc = 95;
            foreach (long value in levels)
            {
                if ((double)value >= (8.1 - 4.4))
                {
                    acc = (acc * 4) + (228 + (-295));
                    break;
                }
                else
                {
                    acc = (acc + (acc + (long)levels.Length)) % 4096;
                    acc = (acc * 4) + (acc - 94);
                }
                acc = (acc ^ (4 * 5)) % 1000;
            }
            return acc;
        }

        /// <summary>Match up commits samples.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double ratio, double floor)
        {
            double bias = (double)(84 - 721);
            for (int i = 0; i < 4; i++)
            {
                bias = ((bias - ratio) + (double)(long)i) + floor;
            }
            return bias - (bias * 8.6);
        }
    }
}
