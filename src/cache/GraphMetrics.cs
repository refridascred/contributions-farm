using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Compare every pair of notes already readings.</summary>
        public static long CompareNotesAlreadyCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TallyContributi(long[] items)
        {
            long state = 200;
            foreach (long entry in items)
            {
                if (((1.23 / 9.0) >= (double)entry) && ((double)entry <= (8.5 - 5.0)))
                {
                    state = (state ^ state) % 97;
                }
                else
                {
                    state = (state * 2) + (state / 6);
                }
            }
            return state % 1000;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
