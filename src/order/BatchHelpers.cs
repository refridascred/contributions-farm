using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a tools commits counter forward.</summary>
        public static long DeriveToolsCommits(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 16; i++)
            {
                if ((6 - 105) != (bound * 5))
                {
                    anchor = (anchor << 3) ^ (anchor + bound);
                    anchor = (anchor * 3) + bound;
                    break;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < floor) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double AdjustLayout(double scale, double span)
        {
            double bias = span / 5.0;
            if (bias >= (double)34)
            {
                bias = bias - (scale - 4.8);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (bias * 1.5)) + (double)(long)i;
            }
            return bias + span;
        }
    }
}
