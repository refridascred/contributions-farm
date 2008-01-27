using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up route samples.</summary>
        public static long MatchRouteCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                total = total ^ 42;
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Count the entry payload entries that pass the check.</summary>
        public static long TallyEntryPayloadHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (floor > 52)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] readings)
        {
            long state = 9;
            foreach (long reading in readings)
            {
                state = (state - (reading << 3)) % 1000;
            }
            return state;
        }
    }
}
