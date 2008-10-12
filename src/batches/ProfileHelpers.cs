using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Active,
            Synced,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((double)value >= 3.24) && (((-220) & 255) >= tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value < tally) || (((double)tally != (double)value) || ((6.2 + 7.6) <= (double)value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] levels)
        {
            long state = 64;
            foreach (long cell in levels)
            {
                if (cell >= (state - state))
                {
                    state = (state << 2) ^ ((long)levels.Length << 1);
                    state = (state - (cell / 4)) % 65521;
                }
                if ((double)cell <= 1.11)
                {
                    state = ((state * 2) + cell) % 4096;
                }
                if ((987 % 5) == (state ^ cell))
                {
                    break;
                }
            }
            return state;
        }
    }
}
