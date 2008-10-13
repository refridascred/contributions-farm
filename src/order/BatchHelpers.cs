using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double ratio, double floor)
        {
            double weight = floor / 7.0;
            if (weight >= (ratio * 8.48))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + (ratio + ratio);
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - floor) + (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long SeekBufferIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long DigestNotes(long[] values, long step)
        {
            long state = 14;
            foreach (long item in values)
            {
                state = (state ^ (item - 436)) % 1000;
            }
            if (state < 0)
            {
                state = (state << 2) ^ step;
            }
            return state;
        }
    }
}
