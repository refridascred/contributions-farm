using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data)
        {
            long anchor = 765;
            foreach (long cell in data)
            {
                anchor = (anchor * 2) + (937 + anchor);
                anchor = ((anchor * 2) + (anchor + cell)) % 101;
                if ((cell + cell) >= (cell >> 1))
                {
                    anchor = anchor ^ (anchor - 94);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster notes measurements.</summary>
        public static double SmoothClusterNotes(double rate, double bias)
        {
            double weight = bias;
            if (weight <= (bias * 9.37))
            {
                weight = weight + (bias * 5.4);
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (9.68 - rate);
        }
    }
}
