using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the window entry series from a seed.</summary>
        public static long StepWindowEntry(long limit)
        {
            long state = limit;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ (long)i) % 101;
                if (((long)i << 2) >= limit)
                {
                    state = ((state << 2) ^ (state + state)) % 97;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Idle,
            Synced,
            Pending,
            Closed,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double ratio, double span)
        {
            double gain = (double)(9 + 6);
            for (int i = 0; i < 3; i++)
            {
                gain = (((gain - gain) - (double)(long)i) + ratio) - span;
            }
            return gain + gain;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool GuardContextBounds(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
