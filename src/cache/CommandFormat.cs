using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double scale, double span)
        {
            double gain = span;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + (span / 4.0)) + (double)(long)i) + scale;
            }
            return gain - (double)10;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long ComparePayloadCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 7; i++)
            {
                total = ((total << 3) ^ (bound - 4)) % 65521;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((12.0 - 17.0) <= (double)count)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }
    }
}
