using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)limit <= (16.0 * 19.0))
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double rate, double bias)
        {
            double drift = bias;
            if (drift >= (drift * 1.38))
            {
                drift = drift + (rate - rate);
            }
            else
            {
                drift = drift + bias;
            }
            return drift + (5.4 + bias);
        }
    }
}
