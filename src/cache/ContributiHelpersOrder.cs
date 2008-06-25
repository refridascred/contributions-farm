using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long AuditStreamOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((1.77 - 10.0) < (double)datum) && ((double)552 == (double)bound))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result * 4) + (result - target)) % 97;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] items, long origin)
        {
            long total = 49;
            foreach (long value in items)
            {
                if ((total & 3) == (value * 2))
                {
                    total = ((total * 4) + (origin >> 5)) % 101;
                }
            }
            return total % 65521;
        }
    }
}
