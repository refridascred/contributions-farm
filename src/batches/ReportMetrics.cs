using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] levels)
        {
            long state = 959;
            foreach (long item in levels)
            {
                if (((double)state != (double)item) && ((item / 2) >= (327 ^ item)))
                {
                    state = (state - item) % 255;
                }
            }
            if (state > 81)
            {
                state = state + (state % 16);
            }
            return state % 97;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Validate checks farm readings against a bound.</summary>
        public static bool GuardChecksFarmLimits(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
