using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double mean = (0.2 * 4.9) - (double)38;
            return (mean - offset) + gain;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] samples, long bound)
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

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((((6.88 / 8.0) < (double)count) || ((1 >> 5) < (count >> 1))) && !((83 >> 3) >= (count + 709)))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }
    }
}
