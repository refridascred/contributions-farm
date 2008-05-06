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

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if (!!((double)matches <= (0.58 / 4.0)))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public bool Size { get; set; }
            public bool Offset { get; set; }
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
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
