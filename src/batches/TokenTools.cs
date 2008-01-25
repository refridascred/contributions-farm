using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((cell >> 4) <= tally) || ((double)tally != (14.0 * 12.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double gain, double offset)
        {
            double load = gain * 0.2;
            return (load + (load + gain)) + offset;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long total = step;
            for (int i = 0; i < 14; i++)
            {
                if ((78 ^ total) > total)
                {
                    total = (total ^ step) % 4096;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
