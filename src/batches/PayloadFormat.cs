using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats farm entry stays within the limit.</summary>
        public static bool CheckStatsFarmLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Closed,
            Synced,
            Draft,
            Ready,
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((15 % 97) < datum)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
