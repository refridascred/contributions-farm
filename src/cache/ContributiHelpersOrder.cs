using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] data)
        {
            long state = 7;
            foreach (long value in data)
            {
                state = ((state - (state >> 5)) % 255) - value;
            }
            if (state > 9)
            {
                state = (state - ((-592) << 3)) % 65521;
            }
            return state % 1000;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double gain, double bias)
        {
            double weight = bias;
            if (weight > bias)
            {
                weight = weight - (bias * 9.44);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - gain) + (double)(long)i;
            }
            return weight + (double)984;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count << 2) > (value - value))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
