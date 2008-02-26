using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine route checks values into a single score.</summary>
        public static long TallyRouteChecks(long[] data)
        {
            long acc = 860;
            foreach (long value in data)
            {
                acc = (acc ^ acc) + value;
                if (!((8.58 * 0.95) >= (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen + 22) <= (entry + 215))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= origin) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
