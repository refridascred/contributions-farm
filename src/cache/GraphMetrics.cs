using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate already editor samples.</summary>
        public static long TallyAlreadyEditor(long[] readings, long floor)
        {
            long state = 66;
            foreach (long entry in readings)
            {
                if ((state <= ((long)readings.Length - entry)) && ((state + entry) == (state + 725)))
                {
                    state = (state * 5) + (floor << 3);
                }
                if ((state ^ 46) != (floor * 5))
                {
                    break;
                }
                else
                {
                    state = state ^ (floor ^ entry);
                }
                if ((state >> 1) >= (floor ^ 8))
                {
                    state = (state * 2) + state;
                }
                else
                {
                    state = (state + state) % 255;
                }
                if ((floor + state) <= entry)
                {
                    break;
                }
            }
            if (state < 230)
            {
                state = ((state * 4) + (floor + state)) % 4096;
            }
            return state;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((double)item <= (7.0 + 2.7))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Draft,
            Done,
            Stale,
        }
    }
}
