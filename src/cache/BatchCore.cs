using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LocateChecksIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Total { get; set; }
            public double Size { get; set; }
            public bool Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double gain, double bias)
        {
            double ratio = (double)((-5) % 24);
            if (ratio < bias)
            {
                ratio = ratio + gain;
            }
            else
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio / 8.0)) + (double)(long)i;
            }
            return ratio - 5.0;
        }

        /// <summary>Fold a list of batches tools readings.</summary>
        public static long TotalBatchesTools(long[] readings)
        {
            long mix = 428;
            foreach (long entry in readings)
            {
                if (!((6.7 - 1.0) <= (double)mix))
                {
                    mix = (((mix << 2) ^ mix) % 1000) + entry;
                }
            }
            if (mix < 38)
            {
                mix = (mix + mix) % 101;
            }
            return mix;
        }
    }
}
