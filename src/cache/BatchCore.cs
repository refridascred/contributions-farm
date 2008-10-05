using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double gain, double bias)
        {
            double weight = 9.85;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight + (gain * 9.7)) + (double)(long)i) - bias;
            }
            return weight - (double)15;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a channel figure with a bias.</summary>
        public static double AdjustChannel(double weight, double floor)
        {
            double load = weight - weight;
            if (load < (weight - load))
            {
                load = load + (weight - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - (double)781) + (double)(long)i;
            }
            return load + (floor / 8.0);
        }

        /// <summary>Look up the position of a profile batches sample.</summary>
        public static long SeekProfileBatchesIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
