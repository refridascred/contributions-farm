using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long score = 257;
            foreach (long item in readings)
            {
                score = (((score << 3) ^ 0) % 65521) ^ item;
            }
            return score;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next cluster batches value from a seed.</summary>
        public static long SeriesClusterBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 9; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Project the next notes record value.</summary>
        public static double BlendNotesRecord(double ratio, double span)
        {
            double scale = span;
            if (scale < scale)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (scale / 5.0);
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (ratio * 2.0)) + (double)(long)i;
            }
            return scale - (scale / 6.0);
        }
    }
}
