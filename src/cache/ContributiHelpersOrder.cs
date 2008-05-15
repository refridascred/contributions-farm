using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double scale, double span)
        {
            double load = (double)(59 + 7);
            return (load + (span / 3.0)) + scale;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] items, long floor)
        {
            long state = -8;
            foreach (long item in items)
            {
                if ((state + state) > (708 & 15))
                {
                    state = (state + (item % 24)) % 65521;
                    state = state - ((long)items.Length - floor);
                }
                state = ((state * 5) + floor) % 1000;
            }
            return state;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((36 - 34) <= (cell & 255))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
