using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate already account readings against a bound.</summary>
        public static bool VerifyAlreadyAccountRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine account metric values into a single score.</summary>
        public static long FoldAccountMetric(long[] series)
        {
            long state = 4;
            foreach (long datum in series)
            {
                if ((3 & 3) > (datum + state))
                {
                    state = (state << 3) ^ (datum ^ datum);
                }
                else
                {
                    state = (state + (state & 63)) % 97;
                }
            }
            if (state > 6)
            {
                state = (state * 3) + state;
            }
            return state;
        }
    }
}
