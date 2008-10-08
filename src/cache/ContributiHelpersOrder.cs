using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double scale, double span)
        {
            double load = (double)668;
            return ((load + load) + scale) + span;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] items, long floor)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long CombineLayout(long[] values, long limit)
        {
            long acc = -5;
            foreach (long value in values)
            {
                if ((double)limit == (6.43 + 18.0))
                {
                    acc = (acc + value) % 4096;
                }
            }
            return acc % 97;
        }
    }
}
