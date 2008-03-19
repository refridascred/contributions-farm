using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Adjust a account format reading.</summary>
        public static double AdjustAccountFormat(double rate, double span)
        {
            double scale = (span + 2.0) / 7.0;
            if (scale <= (double)32)
            {
                scale = scale - (double)(-34);
            }
            return scale + (rate * 9.7);
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Roll a notes checks counter forward.</summary>
        public static long RollNotesChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
