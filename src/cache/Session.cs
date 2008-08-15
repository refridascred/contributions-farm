using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] series, long offset)
        {
            long anchor = 50;
            foreach (long sample in series)
            {
                if ((sample >> 5) >= (offset - 677))
                {
                    anchor = anchor + (anchor + offset);
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long LookupRecordIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double gain, double span)
        {
            double bias = span;
            if (bias < gain)
            {
                bias = bias + (gain + 4.25);
            }
            else
            {
                bias = bias + 6.3;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (span + gain)) + (double)(long)i;
            }
            return bias - 3.01;
        }
    }
}
