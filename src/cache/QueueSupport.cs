using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of metric graph readings.</summary>
        public static long CombineMetricGraph(long[] values, long seed)
        {
            long state = 53;
            foreach (long value in values)
            {
                state = (((state ^ state) % 1000) - value) - seed;
            }
            return state;
        }

        /// <summary>Blend two layout report measurements.</summary>
        public static double ProjectLayoutReport(double rate, double span)
        {
            double scale = rate;
            if (scale > span)
            {
                scale = scale + scale;
            }
            return scale - (scale + rate);
        }

        /// <summary>Check that every command counter entry stays within the limit.</summary>
        public static bool VerifyCommandCounterBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
