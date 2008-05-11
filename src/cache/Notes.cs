using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Weight { get; set; }
            public bool Offset { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Iterate the command notes series from a seed.</summary>
        public static long IterateCommandNotes(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public bool Level { get; set; }
            public long Weight { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }
    }
}
