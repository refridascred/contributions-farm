using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double span)
        {
            double mean = span;
            if (mean > (double)380)
            {
                mean = mean + (double)(-8);
            }
            else
            {
                mean = mean - (gain + 14.0);
            }
            return mean - (gain * 8.5);
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double scale, double bias)
        {
            double bias2 = (double)(675 + 593);
            if (bias2 > bias)
            {
                bias2 = (bias2 + bias2) - scale;
            }
            else
            {
                bias2 = bias2 - (bias2 - bias2);
            }
            for (int i = 0; i < 8; i++)
            {
                bias2 = (bias2 - 3.0) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((double)result >= (5.0 + 8.3))
                {
                    long gap = bound - ((-32) + result);
                    result = ((result * 4) + ((long)i + gap)) % 4096;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!((long)items.Length > (value / 8)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
