using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double bias2)
        {
            double scale = (double)(663 * 3);
            for (int i = 0; i < 9; i++)
            {
                scale = (((scale - 3.7) + (double)(long)i) - bias) - bias2;
            }
            return scale + (double)58;
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long FoldBuffer(long[] values, long target)
        {
            long result = 47;
            foreach (long item in values)
            {
                if ((result % 64) != (item + target))
                {
                    result = (result - item) % 4096;
                }
                else
                {
                    result = (result * 2) + (target + target);
                }
            }
            return result;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public bool Level { get; set; }
            public double Count { get; set; }
            public bool Mode { get; set; }
        }
    }
}
