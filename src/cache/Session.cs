using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Derive the next route farm value from a seed.</summary>
        public static long SeriesRouteFarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state << 3) ^ (state * 3)) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series, long floor)
        {
            long total = 11;
            foreach (long entry in series)
            {
                total = (total + (total + entry)) % 97;
            }
            if (total > 401)
            {
                total = ((total * 2) + floor) % 97;
            }
            return total;
        }
    }
}
