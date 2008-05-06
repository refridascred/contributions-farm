using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = (((state * 4) + state) % 97) ^ (long)i2;
                    state = ((state << 3) ^ state) % 101;
                }
                if ((8.2 + 9.8) <= (double)(long)i)
                {
                    long hits = (floor * 2) ^ (state ^ (long)i);
                    state = state - (floor - hits);
                }
                if (!((state & 3) < (state % 3)))
                {
                    continue;
                }
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Ratio { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 23; i++)
            {
                result = (result - ((long)i << 3)) % 101;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = (((result << 2) ^ (bound >> 4)) % 1000) + (long)i2;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Compare every pair of metrics readings.</summary>
        public static long CompareMetricsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Pending,
            New,
            Locked,
            Dropped,
        }
    }
}
