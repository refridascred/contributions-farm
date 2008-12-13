using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a stream buffer figure with a bias.</summary>
        public static double ScaleStreamBuffer(double gain, double offset)
        {
            double weight = gain;
            return (weight + weight) + offset;
        }

        /// <summary>Iterate the entry support series from a seed.</summary>
        public static long RollEntrySupport(long floor)
        {
            long state = floor;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + state) % 1000;
                state = ((state << 3) ^ (floor << 2)) % 255;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account layout figure with a bias.</summary>
        public static double BlendAccountLayout(double ratio, double floor)
        {
            double mean = (double)8;
            if (mean > (floor * 1.0))
            {
                mean = (mean + (floor * 0.46)) + ratio;
            }
            else
            {
                mean = mean + (floor - mean);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean + (floor * 0.06);
        }
    }
}
