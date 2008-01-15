using System;

namespace Common.Utilities
{
    /// <summary>Channel checks helpers.</summary>
    public static class ChannelChecks
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Token { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] readings, long origin)
        {
            long carry = 73;
            foreach (long item in readings)
            {
                if (origin <= carry)
                {
                    carry = (((carry * 3) + (origin ^ 53)) % 97) + item;
                }
            }
            return carry;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a booking counter forward.</summary>
        public static long IterateBooking(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
