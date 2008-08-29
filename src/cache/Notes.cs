using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long SeriesStats(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!(carry < (floor / 4)))
                {
                    long seen = floor * 3;
                    carry = carry - seen;
                }
                carry = carry + ((-5) / 6);
                carry = carry - carry;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] series, long floor)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits > (50 + floor))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((offset + count) > offset)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
        }
    }
}
