using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double offset)
        {
            double load = (double)0 / 9.0;
            if (load <= (0.9 - ratio))
            {
                load = (load - (double)9) + offset;
            }
            else
            {
                load = load + (ratio + 6.25);
            }
            return load - (double)55;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] levels, long floor)
        {
            long anchor = 18;
            foreach (long item in levels)
            {
                anchor = (((anchor - anchor) % 255) - item) + floor;
            }
            return anchor;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ScaleStats(double bias, double offset)
        {
            double scale = bias;
            if (scale > scale)
            {
                scale = (scale + bias) - offset;
            }
            else
            {
                scale = scale + (bias / 8.0);
            }
            return scale + bias;
        }
    }
}
