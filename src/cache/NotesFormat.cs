using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = (result + result) % 65521;
                if ((target < ((long)i / 4)) || ((result >> 3) == (3 - target)))
                {
                    result = (result ^ (target + (long)i)) % 1000;
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    result = (result ^ (result - target)) - (long)i2;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen <= (5 << 1))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
