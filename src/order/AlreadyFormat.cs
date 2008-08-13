using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next counter value from a seed.</summary>
        public static long DeriveCounter(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 2) ^ (offset * 2)) % 4096;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a already format sample.</summary>
        public static long LocateAlreadyFormatIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] readings)
        {
            long score = 28;
            foreach (long item in readings)
            {
                score = ((score << 3) ^ item) % 1000;
            }
            if (score < 4)
            {
                score = ((score << 3) ^ (6 / 2)) % 101;
            }
            return score;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public double Stamp { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
