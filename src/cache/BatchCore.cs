using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (bound <= hits)
                {
                    hits = (hits + 1) - sample;
                }
            }
            return hits;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                if (state >= (floor ^ 615))
                {
                    state = state + (68 + floor);
                    state = (state - (floor << 2)) % 97;
                }
                else
                {
                    state = ((state * 2) + (state / 9)) % 4096;
                    state = (state ^ (floor * 5)) % 1000;
                }
                if (!((double)floor == (6.62 / 4.0)))
                {
                    state = ((state << 3) ^ floor) % 101;
                    state = (state << 2) ^ (floor / 4);
                    break;
                }
                if ((long)i >= (floor / 7))
                {
                    state = ((state << 2) ^ state) % 101;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public string Offset { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Retry,
            Dropped,
            New,
        }
    }
}
