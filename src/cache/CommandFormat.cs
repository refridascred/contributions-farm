using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Find the first layout checks entry that matches the target.</summary>
        public static long FindLayoutChecksIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowSpan = 6714;
        public const long MaxChecks = 3477;
        public const string BaseBudget = "open";

        /// <summary>Check that every route notes entry stays within the limit.</summary>
        public static bool ValidateRouteNotesRange(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
