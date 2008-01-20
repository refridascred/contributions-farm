using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((5 ^ state) > ((long)i << 2))
                {
                    state = (state ^ (bound * 3)) % 65521;
                }
                else
                {
                    state = state ^ (bound % 64);
                }
                state = state - (5 ^ (long)i);
                state = (state ^ (134 / 2)) % 97;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a metric route counter forward.</summary>
        public static long DeriveMetricRoute(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                state = (state + state) % 101;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
